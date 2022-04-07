namespace SalesWeb_CSharp.Services
{
    public class SalesRecordService
    {
        private readonly SalesWeb_CSharpContext _context;

        public SalesRecordService(SalesWeb_CSharpContext context)
        {
            _context = context;
        }
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(_x => _x.Date <= maxDate.Value);
            }
            return await result
                .Include(y => y.Seller)
                .Include(z => z.Seller.Department)
                .OrderByDescending(x=> x.Date)
                .ToListAsync();
        }
    }
}
