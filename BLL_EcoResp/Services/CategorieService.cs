using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL = DAL_EcoResp.Services;

namespace BLL_EcoResp.Services
{
    public class CategorieService : ICategorieRepository<string>
    {
        private readonly DAL.CategorieService _categorieRepository;
        public CategorieService(DAL.CategorieService categorieRepository)
        {
            _categorieRepository = categorieRepository;
        }
        public IEnumerable<string> Get()
        {
            return _categorieRepository.Get().Select(d => d.ToString());
        }
        void ICRUDRepository<string, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }


        string ICRUDRepository<string, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

        int ICRUDRepository<string, int>.Insert(string data)
        {
            throw new NotImplementedException();
        }

        void ICRUDRepository<string, int>.Update(string data)
        {
            throw new NotImplementedException();
        }
    }
}
