using Business.Abstract;
using Business.Results;
using DataAccess.Abstract;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdminService : IAdminService
    {
        IAdminDal _adminDal;

        public AdminService(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public async Task<IResult> Add(Admin admin)
        {
            await _adminDal.AddAsync(admin);
            return new Result(ResultType.Success, "Başarıyla Eklendi");
        }

        public IDataResult<List<Admin>> GetAll()
        {
            var result = _adminDal.GetAll();
            return DataResultFactory.Success(result, "Başarıyla Listelendi");
        }
    }
}
