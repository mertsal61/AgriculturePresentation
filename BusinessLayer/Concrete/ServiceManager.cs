using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServiceManager:iServiceService
    {
        private readonly iServiceDal _iServiceDal;

        public ServiceManager(iServiceDal iServiceDal)
        {
            _iServiceDal = iServiceDal;
        }

        public void Delete(Service t)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetAll()
        {
            return _iServiceDal.GetAll();
        }

        public Service GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Service t)
        {
            throw new NotImplementedException();
        }

        public void Update(Service t)
        {
            throw new NotImplementedException();
        }
    }
}
