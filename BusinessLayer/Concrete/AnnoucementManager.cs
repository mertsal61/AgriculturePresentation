using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnnoucementManager:iAnnoucementService
    {
        private readonly iAnnoucementDal _annoucementDal;

        public AnnoucementManager(iAnnoucementDal annoucementDal)
        {
            _annoucementDal = annoucementDal;
        }

        public void Delete(Annoucement t)
        {
            _annoucementDal.Delete(t);
        }

        public List<Annoucement> GetAll()
        {
            return _annoucementDal.GetAll();
        }

        public Annoucement GetByID(int id)
        {
            return _annoucementDal.GetByID(id);
        }

        public void Insert(Annoucement t)
        {
            _annoucementDal.Insert(t);
        }

        public void Update(Annoucement t)
        {
            _annoucementDal.Update(t);
        }
    }
}
