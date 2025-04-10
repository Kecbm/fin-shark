using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDBContext _context;
        public StockRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public Task<List<Stock>> GetAllAsync()
        {
            return _context.Stocks.ToListAsync();
        }

        public async Task<Stock?> GetByIdAsync(int id)
        {
            return await _context.Stocks.FindAsync(id);
        }
        
        public async Task<Stock> CreateAsync(Stock stockModel)
        {
            await _context.Stocks.AddAsync(stockModel);

            await _context.SaveChangesAsync();

            return stockModel;
        }
    }
}