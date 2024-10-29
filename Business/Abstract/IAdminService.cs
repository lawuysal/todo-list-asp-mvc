using Business.Results;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminService
    {
        Task<IResult> Add(Admin admin);
        IDataResult<List<Admin>> GetAll();

    }
}
