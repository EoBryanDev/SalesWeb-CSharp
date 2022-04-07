namespace SalesWeb_CSharp.Services
{
    public class SellerService
    {
        private readonly SalesWeb_CSharpContext _context;

        public SellerService(SalesWeb_CSharpContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj)
        {
            obj.Department = _context.Department.First();
            _context.Add(obj);
            
            _context.SaveChanges();
        }
    }
}
