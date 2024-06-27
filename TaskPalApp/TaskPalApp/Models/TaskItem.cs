using System;

namespace TaskPalApp.Models
{
    public enum Priority
    {
        Low,
        Medium,
        High
    }

    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } // Added Description property
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; } // Added Priority property
        public int ProjectId { get; set; }

        public TaskItem()
        {
            // Default constructor
        }

        public TaskItem(int id, string title, string description, bool isCompleted, DateTime dueDate, Priority priority, int projectId)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = isCompleted;
            DueDate = dueDate;
            Priority = priority;
            ProjectId = projectId;
        }

        public override string ToString()
        {
            return $"{Title} (Due: {DueDate.ToShortDateString()}, Priority: {Priority})";
        }
    }
}
