using System;

namespace Project_ManageStudent_PRN212.Models
{
    public partial class Schedule
    {
        public int ScheduleId { get; set; }
        public int ClassId { get; set; }
        public int Slot { get; set; } 
        public DayOfWeek DayOfWeek { get; set; } 
        public bool IsActive { get; set; } 

        public virtual Class Class { get; set; }
    }
}