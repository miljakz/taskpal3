using System;

namespace TaskPalApp
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }

        public override string ToString()
        {
            return $"{Title} - Due: {DueDate.ToShortDateString()}";
        }
    }
}
