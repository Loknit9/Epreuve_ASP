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
            throw new NotImplementedException();
        }

        public int Insert(Media entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Media entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
