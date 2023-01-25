using HW_17._12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HW_17._12
{
    public interface ISupportService
    {
        Task Add(Department department);
        IEnumerable<RequestDto> GetRequests();
    }
}
