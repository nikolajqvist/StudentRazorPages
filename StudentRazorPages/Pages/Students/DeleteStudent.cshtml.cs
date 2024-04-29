using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRazorPages.Models;
using StudentRazorPages.Services;

namespace StudentRazorPages.Pages.Students
{
    public class DeleteStudent : PageModel
    {
        [BindProperty]
        public Student student {  get; set; }
        FakeStudentRepository repo;
        public DeleteStudent(FakeStudentRepository repository)
        {
            repo = repository;
        }
        public void OnGet(int id)
        {
            student = repo.GetStudent(id);
        }
        public IActionResult OnPost()
        {
            repo.DeleteStudent(student);
            return RedirectToPage("Get_Create_Students");
        }
    }
}
