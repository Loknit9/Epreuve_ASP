using BLL_Epreuve.Entities;
using Shared_epreuve.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL = DAL_Epreuve.Entities;


namespace BLL_Epreuve.Services
{
    public class MediaService : IMediaRepository<Media>
    {
        private readonly IMediaRepository<DAL.Media> _mediaRepository;

        public MediaService(IMediaRepository<DAL.Media> mediaRepository)
        {
            _mediaRepository = mediaRepository;
        }


        public IEnumerable<Media> Get()
        {
            return _mediaRepository.Get().Select(d => d.ToBLL());
        }

        public Media Get(int id)
        {
            Media entity = _mediaRepository.Get(id).ToBLL();
            return entity;
        }

        public int Insert(Media data)
        {
            return _mediaRepository.Insert(data.ToDAL());
        }

        public void Update(Media entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _mediaRepository.Delete(id);
        }
    }
}
