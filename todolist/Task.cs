using System;

public class Task
{
    public string Title { get; set; }
    public DateTime DueDate { get; set; }

    public Task(string title, DateTime dueDate)
    {
        Title = title;
        DueDate = dueDate;
    }

    public override string ToString()
    {
        return Title + " - Due: " + DueDate.ToString("yyyy-MM-dd");
    }
}