using Microsoft.AspNetCore.Mvc;
using Shared_epreuve.Repositories;

namespace ASP_Epreuve.Controllers
{
    public class MediaController : Controller
    {
        private readonly IMediaRepository<Media> _mediaRepository;

        public MediaController(IMediaRepository<Media> mediaRepository)
        {
            _mediaRepository = mediaRepository
        }
    }
}
