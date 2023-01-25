using HW_17._12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12
{
    public class SupportService : ISupportService
    {
        private readonly SupportContext _supportContext;
        public SupportService(SupportContext supportContext)
        {
            _supportContext = supportContext;
        }

        public async Task Add(Department department)
        {
            await _supportContext.Departments.AddAsync(department);
            await _supportContext.SaveChangesAsync();
        }

        public IEnumerable<RequestDto> GetRequests()
        {
            var requestTable = (from request in _supportContext.SupportRequests
                                join specialist in _supportContext.SupportSpecialists on request.SupportSpecialistId equals specialist.SupportSpecialistId
                                join department in _supportContext.Departments on specialist.DepartmentId equals department.DepartmentId
                                select new RequestDto
                                {
                                    Topic = request.Topic,
                                    Description = request.Description,
                                    DepartmentName = department.Name,
                                    SpecialistName = specialist.Name,
                                    Status = request.Status
                                }).ToList();
            return requestTable;
        }
    }
}
