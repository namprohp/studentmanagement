using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
using Project_ManageStudent_PRN212.Models;
using System;
using System.Linq;
using System.Windows;

namespace Project_ManageStudent_PRN212.Admin
{
    public partial class ManageSchedule : Window
    {
        private Schedule selectedSchedule;

        public ManageSchedule()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Load class list for combobox
            var classes = ProjectPrn212Context.INSTANCE.Classes
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .Include(c => c.Room)
                .OrderBy(c => c.ClassName)
                .ToList();
            cbbClass.ItemsSource = classes;
            cbbClass.DisplayMemberPath = "ClassName";
            cbbClass.SelectedValuePath = "ClassId";

            RefreshScheduleGrid();
        }

        private void RefreshScheduleGrid()
        {
            var schedules = ProjectPrn212Context.INSTANCE.Schedules
                .Include(s => s.Class)
                .Include(s => s.Class.Course)
                .Include(s => s.Class.Teacher)
                .Include(s => s.Class.Room)
                .Where(s => s.IsActive)
                .OrderBy(s => s.DayOfWeek)
                .ThenBy(s => s.Slot)
                .Select(s => new
                {
                    s.ScheduleId,
                    Class = new
                    {
                        s.Class.ClassId,
                        s.Class.ClassName,
                        Course = new
                        {
                            s.Class.Course.CourseId,
                            s.Class.Course.CourseName
                        },
                        Teacher = new
                        {
                            s.Class.Teacher.Id,
                            s.Class.Teacher.TeacherName
                        },
                        Room = new
                        {
                            s.Class.Room.RoomId,
                            s.Class.Room.RoomName
                        }
                    },
                    s.Slot,
                    s.DayOfWeek,
                    SlotString = GetSlotString(s.Slot),
                    DayOfWeekString = GetDayOfWeekString(s.DayOfWeek)
                })
                .ToList();

            dgSchedule.ItemsSource = schedules;
        }

        private static string GetSlotString(int slot)
        {
            return slot switch
            {
                1 => "Slot 1 (7:30-9:00)",
                2 => "Slot 2 (9:10-10:40)",
                3 => "Slot 3 (10:50-12:20)",
                4 => "Slot 4 (12:50-14:20)",
                5 => "Slot 5 (14:30-16:00)",
                6 => "Slot 6 (16:10-17:40)",
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

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (cbbClass.SelectedItem == null || cbbDayOfWeek.SelectedItem == null || cbbSlot.SelectedItem == null)
                {
                    MessageBox.Show("Please select all required information!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var classId = (int)cbbClass.SelectedValue;
                var dayOfWeek = (DayOfWeek)cbbDayOfWeek.SelectedIndex;
                var slot = cbbSlot.SelectedIndex + 1;

                // Check schedule conflict
                var conflictSchedule = ProjectPrn212Context.INSTANCE.Schedules
                    .FirstOrDefault(s => s.DayOfWeek == dayOfWeek && s.Slot == slot && s.IsActive);

                if (conflictSchedule != null)
                {
                    MessageBox.Show("There is already a class scheduled at this time!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var schedule = new Schedule
                {
                    ClassId = classId,
                    DayOfWeek = dayOfWeek,
                    Slot = slot,
                    IsActive = true
                };

                ProjectPrn212Context.INSTANCE.Schedules.Add(schedule);
                ProjectPrn212Context.INSTANCE.SaveChanges();
                RefreshScheduleGrid();
                MessageBox.Show("Schedule added successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedSchedule == null)
                {
                    MessageBox.Show("Please select a schedule to update!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var dayOfWeek = (DayOfWeek)cbbDayOfWeek.SelectedIndex;
                var slot = cbbSlot.SelectedIndex + 1;

                // Check schedule conflict
                var conflictSchedule = ProjectPrn212Context.INSTANCE.Schedules
                    .FirstOrDefault(s => s.ScheduleId != selectedSchedule.ScheduleId &&
                                       s.DayOfWeek == dayOfWeek &&
                                       s.Slot == slot &&
                                       s.IsActive);

                if (conflictSchedule != null)
                {
                    MessageBox.Show("There is already a class scheduled at this time!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                selectedSchedule.DayOfWeek = dayOfWeek;
                selectedSchedule.Slot = slot;

                ProjectPrn212Context.INSTANCE.SaveChanges();
                RefreshScheduleGrid();
                MessageBox.Show("Schedule updated successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selectedSchedule == null)
                {
                    MessageBox.Show("Please select a schedule to delete!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                var result = MessageBox.Show("Are you sure you want to delete this schedule?", "Confirm Delete",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    selectedSchedule.IsActive = false;
                    ProjectPrn212Context.INSTANCE.SaveChanges();
                    RefreshScheduleGrid();
                    MessageBox.Show("Schedule deleted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void dgSchedule_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (dgSchedule.SelectedItem != null)
            {
                var selected = ((dynamic)dgSchedule.SelectedItem);
                int scheduleId = selected.ScheduleId;

                selectedSchedule = ProjectPrn212Context.INSTANCE.Schedules
                    .FirstOrDefault(s => s.ScheduleId == scheduleId);

                if (selectedSchedule != null)
                {
                    cbbClass.SelectedValue = selectedSchedule.ClassId;
                    cbbDayOfWeek.SelectedIndex = (int)selectedSchedule.DayOfWeek;
                    cbbSlot.SelectedIndex = selectedSchedule.Slot - 1;
                }
            }
        }

        private void btnExport_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Schedule");

                    // Header
                    worksheet.Cell("A1").Value = "CLASS SCHEDULE";
                    worksheet.Range("A1:G1").Merge();
                    worksheet.Cell("A1").Style
                        .Font.SetBold(true)
                        .Font.SetFontSize(16)
                        .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                    // Column Headers
                    worksheet.Cell("A3").Value = "Day";
                    worksheet.Cell("B3").Value = "Slot";
                    worksheet.Cell("C3").Value = "Class";
                    worksheet.Cell("D3").Value = "Course";
                    worksheet.Cell("E3").Value = "Teacher";
                    worksheet.Cell("F3").Value = "Room";
                    worksheet.Range("A3:F3").Style.Font.SetBold(true);

                    // Data
                    var scheduleView = (System.Collections.IList)dgSchedule.ItemsSource;
                    int row = 4;
                    foreach (dynamic schedule in scheduleView)
                    {
                        worksheet.Cell($"A{row}").Value = schedule.DayOfWeekString;
                        worksheet.Cell($"B{row}").Value = schedule.SlotString;
                        worksheet.Cell($"C{row}").Value = schedule.Class.ClassName;
                        worksheet.Cell($"D{row}").Value = schedule.Class.Course.CourseName;
                        worksheet.Cell($"E{row}").Value = schedule.Class.Teacher.TeacherName;
                        worksheet.Cell($"F{row}").Value = schedule.Class.Room.RoomName;
                        row++;
                    }

                    // Formatting
                    worksheet.Columns().AdjustToContents();
                    var tableRange = worksheet.Range(3, 1, row - 1, 6);
                    tableRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                    tableRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;

                    // Save file
                    var saveDialog = new Microsoft.Win32.SaveFileDialog
                    {
                        Filter = "Excel Files|*.xlsx",
                        FileName = $"Schedule_{DateTime.Now:yyyyMMdd}"
                    };

                    if (saveDialog.ShowDialog() == true)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Schedule exported successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting schedule: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            var home = new HomeScreenAdmin();
            home.Show();
            this.Close();
        }
    }
}