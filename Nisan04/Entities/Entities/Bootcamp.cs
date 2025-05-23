﻿public class Bootcamp
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int InstructorId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public BootcampState BootcampState { get; set; }

    public ICollection<Application> Applications { get; set; }
}

public enum BootcampState
{
    PREPARING,
    OPEN_FOR_APPLICATION,
    IN_PROGRESS,
    FINISHED,
    CANCELLED
}