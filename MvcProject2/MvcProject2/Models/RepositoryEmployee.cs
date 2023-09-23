namespace MvcProject2.Models
{
    public class RepositoryEmployee
    {
        private NorthwindContext _context;
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> AllEmployees() 
        {
            return _context.Employees.ToList(); //Null pointer exception
        }
    }
}
