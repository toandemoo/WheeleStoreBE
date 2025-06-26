using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.DTOs;
using Project.Entities;
using Project.Models.Pagination;
using ProjectBE.Dtos.Request;

namespace Project.Repository.interfaces
{
    public interface ICarRepository : IRepository<Cars>
    {
        Task<Pagination<CarDTO>> FilterCar(FilterCarRequest req);
    }
}