using AutoMapper;
using Human.Resources.Domain.Core.Notification;
using Human.Resources.Domain.Dtos;
using Human.Resources.Domain.Entities;
using Human.Resources.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Human.Resources.Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly DomainNotification _notificationContext;
        private IMapper _mapper;

        public EmployeeService(IEmployeeRepository repository, DomainNotification notificationContext, IMapper mapper) 
        {
            _repository = repository;
            _notificationContext = notificationContext;
            _mapper = mapper;
        }

        public void Delete(int id)
        {
            _repository.Remove(id);
        }

        public async Task<IList<EmployeeDto>> GetAll()
        {
            var entity = await _repository.GetAll();

            return _mapper.Map<IList<EmployeeDto>>(entity);
        }

        public async Task<EmployeeDto> GetById(int id)
        {
            var entity = await _repository.GetById(id);

            return _mapper.Map<EmployeeDto>(entity);
        }

        public async Task<Employee> Post(EmployeeDto employeeDto)
        {
            var entity = _mapper.Map<Employee>(employeeDto);

            if (!entity.IsValid())
            {
                _notificationContext.AddNotifications(entity.ValidationResult);
                return entity;
            }

            await _repository.Insert(entity);
            return entity;
        }

        public async Task<Employee> Put(EmployeeDto employeeDto)
        {
            var entity = _mapper.Map<Employee>(employeeDto);

            if (!entity.IsValid())
            {
                _notificationContext.AddNotifications(entity.ValidationResult);
                return entity;
            }

            await _repository.Update(entity);
            return entity;
        }
    }
}
