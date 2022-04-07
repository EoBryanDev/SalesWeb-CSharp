namespace SalesWeb_CSharp.Services;


    public class DepartmentService
    {
        private readonly SalesWeb_CSharpContext _context;

        public DepartmentService(SalesWeb_CSharpContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
    {
        return await _context.Department.OrderBy(x => x.Name).ToListAsync();
    }
    }

