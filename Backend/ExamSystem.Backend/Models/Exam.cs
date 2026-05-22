namespace ExamSystem.Backend.Models;

public class Exam
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string PaperType { get; set; } = string.Empty;
    public int Duration { get; set; } = 60;
    public int TotalScore { get; set; } = 100;
    public string QuestionIds { get; set; } =