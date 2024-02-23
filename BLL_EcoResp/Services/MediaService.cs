using BLL_EcoResp.Entities;
using DAL = DAL_EcoResp.Entities;
using Shared;
using System;
using System.Collections.Generic;
using System.Text;
using BLL_EcoResp.Mapper;

namespace BLL_EcoResp.Services
{
    public class MediaService : IMediaRepository<Media>
    {
        private readonly IMediaRepository<DAL.Media> _repository;
        public MediaService(IMediaRepository<DAL.Media> repository)
        {
            _repository = repository;
        }

        public int Insert(Media data)
        {
            return _repository.Insert(data.ToDAL());
        }


        void ICRUDRepository<Media, int>.Delete(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Media> ICRUDRepository<Media, int>.Get()
        {
            throw new NotImplementedException();
        }

        Media ICRUDRepository<Media, int>.Get(int id)
        {
            throw new NotImplementedException();
        }

     
        void ICRUDRepository<Media, int>.Update(Media data)
        {
            throw new NotImplementedException();
        }
    }
}
