using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentRazorPages.Models;
using StudentRazorPages.Services;

namespace StudentRazorPages.Pages.Students
{
    public class EditStudentModel : PageModel
    {
        [BindProperty]
        public Student student {  get; set; }

        FakeStudentRepository repo;
        public EditStudentModel(FakeStudentRepository repository)
        {
            repo = repository;
            student = new Student();
        }
        public void OnGet(int id)
        {
           student = repo.GetStudent(id);
        }
        public IActionResult OnPost()
        {
            repo.UpdateStudent(student);
            return RedirectToPage("Get_Create_Students");
        }
    }
}
