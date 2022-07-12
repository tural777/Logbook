namespace Logbook.Models;

public class Student
{
    public int Number { get; set; }
    public string? PictureUrl { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? FatherName { get; set; }
    public DateTime? LastIn { get; set; }
    public ParticipationStatus Status { get; set; }
    public byte? LaboratoryWork { get; set; }
    public byte? ClassWork { get; set; }
    public byte? ActivityCrystal { get; set; }
    public string? Comment { get; set; }



    public Student(int number, string? pictureUrl, string? firstName, string? lastName, string? fatherName, DateTime? lastIn, ParticipationStatus status, byte? laboratoryWork, byte? classWork, byte? activityCrystal, string? comment)
    {
        Number = number;
        PictureUrl = pictureUrl;
        FirstName = firstName;
        LastName = lastName;
        FatherName = fatherName;
        LastIn = lastIn;
        Status = status;
        LaboratoryWork = laboratoryWork;
        ClassWork = classWork;
        ActivityCrystal = activityCrystal;
        Comment = comment;
    }


    public string? FullName() => $"{FirstName} {LastName} {FatherName}";
}


public enum ParticipationStatus
{
    Unknown,
    Present,
    Absent,
    Late
}