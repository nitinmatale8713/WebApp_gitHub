using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SqlApp.Model;
using SqlApp.Service;
using SqlApp.Service.Abstract;

namespace WebApp_gitHub.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IEmployee _employeeservice;
        public List<Employee> emp_lst = new List<Employee>();

        public IndexModel(IEmployee employeeservice)
        {
            _employeeservice = employeeservice;
        }
         
        public void OnGet()
        {
            emp_lst = _employeeservice.GetEmployees();

        }
    }
}