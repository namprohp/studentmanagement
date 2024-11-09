using Project_ManageStudent_PRN212.Models;
using System;
using System.Linq;
using System.Windows;
using LiveCharts;
using LiveCharts.Wpf;
using ClosedXML.Excel;

namespace Project_ManageStudent_PRN212.Admin
{
    public partial class AdminDashboard : Window
    {
        public SeriesCollection StudentsByClassCollection { get; set; }
        public SeriesCollection GenderCollection { get; set; }
        public SeriesCollection TeacherClassesCollection { get; set; }
        public string[] ClassLabels { get; set; }
        public string[] TeacherLabels { get; set; }

        public AdminDashboard()
        {
            InitializeComponent();
            LoadDashboardData();
            DataContext = this;
        }

        private void LoadDashboardData()
        {
            // Students per class statistics
            var studentsByClass = ProjectPrn212Context.INSTANCE.StudentClasses
                .GroupBy(sc => sc.Class.ClassName)
                .Select(g => new
                {
                    ClassName = g.Key,
                    StudentCount = g.Count()
                })
                .ToList();

            ClassLabels = studentsByClass.Select(x => x.ClassName).ToArray();
            StudentsByClassCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Students",
                    Values = new ChartValues<int>(studentsByClass.Select(x => x.StudentCount).ToList())
                }
            };

            // Gender statistics
            var genderStats = ProjectPrn212Context.INSTANCE.Students
                .GroupBy(s => s.Gender)
                .Select(g => new
                {
                    Gender = g.Key == true ? "Male" : "Female",
                    Count = g.Count()
                })
                .ToList();

            GenderCollection = new SeriesCollection();
            foreach (var stat in genderStats)
            {
                GenderCollection.Add(new PieSeries
                {
                    Title = stat.Gender,
                    Values = new ChartValues<int> { stat.Count },
                    DataLabels = true
                });
            }

            // Teachers' class statistics
            var teacherClassStats = ProjectPrn212Context.INSTANCE.Classes
                .GroupBy(c => c.Teacher.TeacherName)
                .Select(g => new
                {
                    TeacherName = g.Key,
                    ClassCount = g.Count()
                })
                .ToList();

            TeacherLabels = teacherClassStats.Select(x => x.TeacherName).ToArray();
            TeacherClassesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Classes",
                    Values = new ChartValues<int>(teacherClassStats.Select(x => x.ClassCount).ToList())
                }
            };

            // Summary statistics
            txtTotalStudents.Text = ProjectPrn212Context.INSTANCE.Students.Count().ToString();
            txtTotalTeachers.Text = ProjectPrn212Context.INSTANCE.Teachers.Count().ToString();
            txtTotalClasses.Text = ProjectPrn212Context.INSTANCE.Classes.Count().ToString();
            txtTotalCourses.Text = ProjectPrn212Context.INSTANCE.Courses.Count().ToString();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var home = new HomeScreenAdmin();
            home.Show();
            this.Close();
        }

        private void btnExportReport_Click(object sender, RoutedEventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Statistics Report");

                    // Title
                    worksheet.Cell("A1").Value = "STUDENT MANAGEMENT STATISTICS REPORT";
                    worksheet.Range("A1:F1").Merge();
                    worksheet.Cell("A1").Style
                        .Font.SetBold(true)
                        .Font.SetFontSize(16)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // Report time
                    worksheet.Cell("A2").Value = $"Report Time: {DateTime.Now:dd/MM/yyyy HH:mm}";
                    worksheet.Range("A2:F2").Merge();
                    worksheet.Cell("A2").Style
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // Overview Statistics
                    worksheet.Cell("A4").Value = "OVERVIEW STATISTICS";
                    worksheet.Range("A4:B4").Style.Font.SetBold(true);

                    worksheet.Cell("A5").Value = "Total Students:";
                    worksheet.Cell("B5").Value = ProjectPrn212Context.INSTANCE.Students.Count();

                    worksheet.Cell("A6").Value = "Total Teachers:";
                    worksheet.Cell("B6").Value = ProjectPrn212Context.INSTANCE.Teachers.Count();

                    worksheet.Cell("A7").Value = "Total Classes:";
                    worksheet.Cell("B7").Value = ProjectPrn212Context.INSTANCE.Classes.Count();

                    worksheet.Cell("A8").Value = "Total Courses:";
                    worksheet.Cell("B8").Value = ProjectPrn212Context.INSTANCE.Courses.Count();

                    // Students per Class Statistics
                    worksheet.Cell("A10").Value = "STUDENTS PER CLASS STATISTICS";
                    worksheet.Range("A10:D10").Style.Font.SetBold(true);

                    worksheet.Cell("A11").Value = "Class";
                    worksheet.Cell("B11").Value = "Total Students";
                    worksheet.Cell("C11").Value = "Male";
                    worksheet.Cell("D11").Value = "Female";

                    var classStats = ProjectPrn212Context.INSTANCE.Classes
                        .Select(c => new
                        {
                            c.ClassName,
                            TotalStudents = c.StudentClasses.Count,
                            MaleStudents = c.StudentClasses.Count(sc => sc.Student.Gender == true),
                            FemaleStudents = c.StudentClasses.Count(sc => sc.Student.Gender == false)
                        })
                        .ToList();

                    int currentRow = 12;
                    foreach (var stat in classStats)
                    {
                        worksheet.Cell($"A{currentRow}").Value = stat.ClassName;
                        worksheet.Cell($"B{currentRow}").Value = stat.TotalStudents;
                        worksheet.Cell($"C{currentRow}").Value = stat.MaleStudents;
                        worksheet.Cell($"D{currentRow}").Value = stat.FemaleStudents;
                        currentRow++;
                    }

                    // Teacher Statistics
                    currentRow += 2;
                    worksheet.Cell($"A{currentRow}").Value = "TEACHER STATISTICS";
                    worksheet.Range($"A{currentRow}:E{currentRow}").Style.Font.SetBold(true);

                    currentRow++;
                    worksheet.Cell($"A{currentRow}").Value = "Teacher ID";
                    worksheet.Cell($"B{currentRow}").Value = "Teacher Name";
                    worksheet.Cell($"C{currentRow}").Value = "Email";
                    worksheet.Cell($"D{currentRow}").Value = "Classes";
                    worksheet.Cell($"E{currentRow}").Value = "Class List";

                    var teacherStats = ProjectPrn212Context.INSTANCE.Teachers
                        .Select(t => new
                        {
                            t.Id,
                            t.TeacherName,
                            t.Email,
                            ClassCount = t.Classes.Count,
                            Classes = string.Join(", ", t.Classes.Select(c => c.ClassName))
                        })
                        .ToList();

                    currentRow++;
                    foreach (var teacher in teacherStats)
                    {
                        worksheet.Cell($"A{currentRow}").Value = teacher.Id;
                        worksheet.Cell($"B{currentRow}").Value = teacher.TeacherName;
                        worksheet.Cell($"C{currentRow}").Value = teacher.Email;
                        worksheet.Cell($"D{currentRow}").Value = teacher.ClassCount;
                        worksheet.Cell($"E{currentRow}").Value = teacher.Classes;
                        currentRow++;
                    }

                    // Formatting
                    worksheet.Columns().AdjustToContents();
                    var tableRange = worksheet.Range(1, 1, currentRow - 1, 5);
                    tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // Save file
                    var saveDialog = new Microsoft.Win32.SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        FileName = $"StudentManagementReport_{DateTime.Now:yyyyMMdd}"
                    };

                    if (saveDialog.ShowDialog() == true)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Report exported successfully!", "Success",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}