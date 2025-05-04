using Entities;

public class Application
{
    public int Id { get; set; }
    public int ApplicantId { get; set; }
    public int BootcampId { get; set; }
    public ApplicationState ApplicationState { get; set; }

    public Bootcamp Bootcamp { get; set; }
}

public enum ApplicationState
{
    PENDING,
    APPROVED,
    REJECTED,
    IN_REVIEW,
    CANCELLED
}