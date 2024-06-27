using System;

namespace TaskPalApp.Models
{
    public class ProjectItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsUrgent { get; set; }
        public DateTime DueDate { get; set; }
    }
}
