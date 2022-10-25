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
    public class ImageManager : iImageService
    {
        private readonly iImageDal _imagedal;

        public ImageManager(iImageDal imagedal)
        {
            _imagedal = imagedal;
        }

        public void Delete(Image t)
        {
            _imagedal.Delete(t);
        }

        public List<Image> GetAll()
        {
            return _imagedal.GetAll();  
        }

        public Image GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Image t)
        {
            throw new NotImplementedException();
        }

        public void Update(Image t)
        {
            throw new NotImplementedException();
        }
    }
}
