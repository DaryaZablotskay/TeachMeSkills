using hw_09_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw_09_12
{
    public interface ILibraryService
    {
        Task FillUser(UserBook user);
    }
}
