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
    }
}
