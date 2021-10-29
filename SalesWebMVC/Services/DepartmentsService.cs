using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;


namespace SalesWebMVC.Services
{
    public class DepartmentsService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentsService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Departments> FindAll()
        {
            return _context.Departments.OrderBy(x => x.Name).ToList();
        }
    }
}
