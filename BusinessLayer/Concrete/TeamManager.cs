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
    public class TeamManager:iTeamService
    {
        private readonly iTeamDal _iTeamDal;

        public TeamManager(iTeamDal iTeamDal)
        {
            _iTeamDal = iTeamDal;
        }

        public void Delete(Team t)
        {
            _iTeamDal.Delete(t);
        }

        public List<Team> GetAll()
        {
            return _iTeamDal.GetAll();
        }

        public Team GetByID(int id)
        {
            return _iTeamDal.GetByID(id);
        }

        public void Insert(Team t)
        {
            _iTeamDal.Insert(t);
        }

        public void Update(Team t)
        {
            _iTeamDal.Update(t);
        }
    }
}
