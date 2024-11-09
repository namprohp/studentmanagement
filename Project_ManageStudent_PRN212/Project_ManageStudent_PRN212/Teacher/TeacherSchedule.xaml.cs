using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Project_ManageStudent_PRN212.Models;
using System;
using System.Linq;
using System.Windows;

namespace Project_ManageStudent_PRN212.Teacher
{
    public partial class TeacherSchedule : Window
    {
        private readonly string teacherId;

        public TeacherSchedule(string teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            var schedules = ProjectPrn212Context.INSTANCE.Schedules
                .Include(s => s.Class)
                    .ThenInclude(c => c.Course)
                .Include(s => s.Class)
                    .ThenInclude(c => c.Room)
                .Where(s => s.Class.TeacherId == teacherId && s.IsActive)
                .OrderBy(s => s.DayOfWeek)
                .ThenBy(s => s.Slot)
                .Select(s => new
                {
                    s.ScheduleId,
                    s.Class.ClassName,
                    CourseName = s.Class.Course.CourseName,
                    RoomName = s.Class.Room.RoomName,
                    Day = GetDayOfWeekString(s.DayOfWeek),
                    Time = GetSlotString(s.Slot)
                })
                .ToList();

            dgSchedule.ItemsSource = schedules;
        }

        private static string GetSlotString(int slot)
        {
            return slot switch
            {
                1 => "07:30 - 09:00",
                2 => "09:10 - 10:40",
                3 => "10:50 - 12:20",
                4 => "12:50 - 14:20",
                5 => "14:30 - 16:00",
                6 => "16:10 - 17:40",
                _ => "Unknown"
            };
        }

        private static string GetDayOfWeekString(DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Monday => "Monday",
                DayOfWeek.Tuesday => "Tuesday",
                DayOfWeek.Wednesday => "Wednesday",
                DayOfWeek.Thursday => "Thursday",
                DayOfWeek.Friday => "Friday",
                DayOfWeek.Saturday => "Saturday",
                DayOfWeek.Sunday => "Sunday",
                _ => "Unknown"
            };
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            LoadSchedule();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var home = new HomeScreenTeacher(teacherId);
            home.Show();
            this.Close();
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Schedule");

                    // Title
                    worksheet.Cell("A1").Value = "TEACHER SCHEDULE";
                    worksheet.Range("A1:F1").Merge();
                    worksheet.Cell("A1").Style
                        .Font.SetBold(true)
                        .Font.SetFontSize(16)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // Teacher info
                    var teacher = ProjectPrn212Context.INSTANCE.Teachers.First(t => t.Id == teacherId);
                    worksheet.Cell("A2").Value = $"Teacher Name: {teacher.TeacherName}";
                    worksheet.Cell("A3").Value = $"Teacher ID: {teacher.Id}";

                    // Headers
                    int currentRow = 5;
                    worksheet.Cell($"A{currentRow}").Value = "Course";
                    worksheet.Cell($"B{currentRow}").Value = "Class";
                    worksheet.Cell($"C{currentRow}").Value = "Room";
                    worksheet.Cell($"D{currentRow}").Value = "Day";
                    worksheet.Cell($"E{currentRow}").Value = "Time";
                    worksheet.Range($"A{currentRow}:E{currentRow}").Style.Font.SetBold(true);

                    // Data
                    var scheduleView = (System.Collections.IList)dgSchedule.ItemsSource;
                    foreach (dynamic schedule in scheduleView)
                    {
                        currentRow++;
                        worksheet.Cell($"A{currentRow}").Value = schedule.CourseName;
                        worksheet.Cell($"B{currentRow}").Value = schedule.ClassName;
                        worksheet.Cell($"C{currentRow}").Value = schedule.RoomName;
                        worksheet.Cell($"D{currentRow}").Value = schedule.Day;
                        worksheet.Cell($"E{currentRow}").Value = schedule.Time;
                    }

                    // Formatting
                    worksheet.Columns().AdjustToContents();
                    var tableRange = worksheet.Range($"A5:E{currentRow}");
                    tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // Save file
                    var saveDialog = new Microsoft.Win32.SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        FileName = $"TeacherSchedule_{teacher.Id}_{DateTime.Now:yyyyMMdd}"
                    };

                    if (saveDialog.ShowDialog() == true)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Schedule exported successfully!", "Success",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting schedule: {ex.Message}", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}