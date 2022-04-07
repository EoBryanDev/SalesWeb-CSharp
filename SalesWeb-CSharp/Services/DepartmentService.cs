namespace SalesWeb_CSharp.Services;


    public class DepartmentService
    {
        private readonly SalesWeb_CSharpContext _context;

        public DepartmentService(SalesWeb_CSharpContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
    {
        return _context.Department.OrderBy(x => x.Name).ToList();
    }
    }

