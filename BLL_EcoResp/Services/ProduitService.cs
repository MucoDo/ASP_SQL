using BLL_EcoResp.Entities;
using DAL=DAL_EcoResp.Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BLL_EcoResp.Mapper;

namespace BLL_EcoResp.Services
{
    public class ProduitService : IProduitRepository<Produit>
    {
        private readonly IProduitRepository<DAL.Produit> _repository;
        public ProduitService(IProduitRepository<DAL.Produit> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Produit> Get()
        {
          return _repository.Get().Select(d=>d.ToBLL());
        }

        public Produit Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        void ICRUDRepository<Produit, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        int ICRUDRepository<Produit, int>.Insert(Produit data)
        {
            throw new NotImplementedException();
        }

        void ICRUDRepository<Produit, int>.Update(Produit data)
        {
            throw new NotImplementedException();
        }
    }
}
