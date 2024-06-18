using System;

namespace TaskPalApp
{
    public class ProjectItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }

        public override string ToString()
        {
            return $"{Title} - Due: {DueDate.ToShortDateString()}";
        }
    }
}
