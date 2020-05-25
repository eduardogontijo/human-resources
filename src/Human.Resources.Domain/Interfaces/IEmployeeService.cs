using Human.Resources.Domain.Dtos;
using Human.Resources.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Human.Resources.Domain.Interfaces
{
    public interface IEmployeeService
    {
        Task<IList<EmployeeDto>> GetAll();
        Task<EmployeeDto> GetById(int id);
        Task<Employee> Post(EmployeeDto obj);
        Task<Employee> Put(EmployeeDto obj);
        void Delete(int id);
    }
}
