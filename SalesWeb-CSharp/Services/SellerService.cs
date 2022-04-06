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
    }
}
