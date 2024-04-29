using StudentRazorPages.Models;

namespace StudentRazorPages.Services
{
    public class FakeStudentRepository
    {
        Dictionary<int, Student> students;
        public FakeStudentRepository()
        {
            students = new Dictionary<int, Student>();
            students.Add(11, new Student() { Id = 11, Name = "Alekx", ImagePath = "/ouch.jpg" });
            students.Add(12, new Student() { Id = 12, Name = "Anna", ImagePath = "/posty.JPG" });
            students.Add(14, new Student() { Id = 14, Name = "Alex", ImagePath = "/POSTYFTW.JPG" });
            students.Add(13, new Student() { Id = 13, Name = "Alexandra", ImagePath = "/wrapped2019.PNG" });
        }
        public Dictionary<int, Student> GetAllStudents()
        {
            return students;
        }
        public void AddStudent(Student student)
        {
            students.Add(student.Id, student);
        }
        public Student GetStudent(int id)
        {
            return students[id];
        }
        public void UpdateStudent(Student student)
        {
            if(student != null)
            {
                students[student.Id].Id = student.Id;
                students[student.Id].Name = student.Name;
                students[student.Id].ImagePath = student.ImagePath;
                students[student.Id].Section = student.Section;
            }
        }
        public void DeleteStudent(Student student)
        {
            students.Remove(student.Id);
        }
    }
}
