using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRazorPages.Models;
using StudentRazorPages.Services;

namespace StudentRazorPages.Pages.Students
{
    public class Get_Create_StudentsModel : PageModel
    {
        public Dictionary<int, Student> students { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Criteria { get; set; }
        [BindProperty]
        public Student student { get; set; }

        FakeStudentRepository repo;
        public Get_Create_StudentsModel(FakeStudentRepository repository)
        {
            repo = repository;
            students = repo.GetAllStudents();
        }
        public IActionResult OnGet()
        {
            ViewData["Message"] = "Hello world, welcome to Zealand Academy!";

            if (!String.IsNullOrEmpty(Criteria))
            {
                students = FilteredStudent(Criteria);
            }
            return Page();
        }
        public IActionResult OnPost()
        {
            repo.AddStudent(student);
            return RedirectToAction("OnGet");
        }
        public Dictionary<int, Student> FilteredStudent(string Criteria)
        {
            Dictionary<int, Student> filteredDictionary = new Dictionary<int, Student>();
            foreach (var s in repo.GetAllStudents().Values)
            {
                if (s.Name.StartsWith(Criteria))
                {
                    filteredDictionary.Add(s.Id, s);
                }
            }
            return filteredDictionary;
        }
    }
}
