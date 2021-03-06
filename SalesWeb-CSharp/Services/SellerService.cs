using Microsoft.EntityFrameworkCore;
using SalesWeb_CSharp.Services.Exceptions;

namespace SalesWeb_CSharp.Services;



public class SellerService
{
    private readonly SalesWeb_CSharpContext _context;

    public SellerService(SalesWeb_CSharpContext context)
    {
        _context = context;
    }

    public async Task<List<Seller>> FindAllAsync()
    {
        return await _context.Seller.ToListAsync();
    }
    public async Task InsertAsync(Seller obj)
    {
       
        _context.Add(obj);
        
        await _context.SaveChangesAsync();
    }

    public async Task<Seller> FindByIdAsync(int id)
    {
        return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
    }
    public async Task RemoveAsync(int id)
    {
        try
        {
            var obj = await _context.Seller.FindAsync(id);
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        } catch(DbUpdateException e)
        {
            throw new IntegrityException("You can not delete that seller because he/she has sales");
        }
    }

    public async Task UpdateAsync(Seller obj)
    {
        bool hasAny = await _context.Seller.AnyAsync(x => x.Id == obj.Id);
        if (!hasAny)
        {
            throw new NotFoundException("Id not found");
        }
        try 
        { 
            _context.Update(obj);
            await _context.SaveChangesAsync();
        } catch(DbUpdateConcurrencyException ex)
        {
            throw new DbConcurrencyException(ex.Message);
        }
    }
}
