namespace CIS3285_Unit4_StudentMVC_2024.Models
{
    public interface IStudentModel
    {
        int Credits { get; set; }
        int Id { get; set; }
        string Name { get; set; }
    }
}