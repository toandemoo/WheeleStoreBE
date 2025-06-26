using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Data;
using Project.DTOs;
using Project.Entities;
using Project.Models.Pagination;
using Project.Repository.interfaces;
using ProjectBE.Dtos.Request;

namespace Project.Repository
{
    public class CarRepository : Repository<Cars>, ICarRepository
    {
        public CarRepository(AppDbContext context) : base(context) { }

        public override async Task<List<Cars>> GetAllAsync()
        {
            return await _dbSet
                .Include(c => c.Brands)
                .Include(c => c.CarTypes)
                .ToListAsync();
        }

        public override async Task<Cars> GetByIdAsync(int id)
        {
            return await _dbSet.Include(c => c.Brands)
                            .Include(c => c.CarTypes)
                            .FirstOrDefaultAsync(c => c.Id == id);

        }

        public async Task<Pagination<CarDTO>> FilterCar(FilterCarRequest req)
        {
            var query = _dbSet.Include(p => p.Brands)
                            .Include(p => p.CarTypes)
                            .AsQueryable();

            if (!string.IsNullOrEmpty(req.Keyword))
            {
                query = query.Where(p => p.Name.ToLower().Contains(req.Keyword.ToLower()));
            }

            if (req.Brand != null)
            {
                query = query.Where(p => p.Brands.Name == req.Brand);
            }

            if (req.CarType != null)
            {
                query = query.Where(p => p.CarTypes.Name == req.CarType);
            }

            if (req.PriceMin.HasValue)
            {
                query = query.Where(p => p.PricePerDay >= req.PriceMin);
            }

            if (req.PriceMax.HasValue)
            {
                query = query.Where(p => p.PricePerDay <= req.PriceMax);
            }

            // Sort
            query = req.SortBy switch
            {
                "price-asc" => query.OrderBy(p => p.PricePerDay),
                "price-desc" => query.OrderByDescending(p => p.PricePerDay),
                "name-asc" => query.OrderBy(p => p.Name),
                "name-desc" => query.OrderByDescending(p => p.Name),
                _ => query.OrderByDescending(p => p.CreatedAt)
            };

            // // Paging
            var total = await query.CountAsync();
            // var data = await query.Skip((req.Page - 1) * req.PageSize).Take(req.PageSize)
            //                       .Select(p => new CarDTO(p)
            //                       ).ToListAsync();
            var data = await query.Select(p => new CarDTO(p)
                                  ).ToListAsync();

            return new Pagination<CarDTO>(req.Page, req.PageSize, total, data);
        }
    }
}