﻿using Human.Resources.Domain.Dtos;
using Human.Resources.Domain.Entities;
using System.Threading.Tasks;

namespace Human.Resources.Domain.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<bool> UpdateStatus(Employee obj);
    }
}
