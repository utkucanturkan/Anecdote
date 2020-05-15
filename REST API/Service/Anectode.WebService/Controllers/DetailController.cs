using Anectode.WebService.Filters;
using BusinessLogicLayer.Abstracts;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Anectode.WebService.Controllers
{
    [RoutePrefix("api/Detail"), AnecdoteExceptionFilter]
    public class DetailController : ApiController
    {
        private readonly IDetailService service;

        public DetailController(IDetailService _service)
        {
            service = _service;
        }

        [HttpPost, Route("Like/{id:int}/{step:int}")]
        public HttpResponseMessage Like(int id, int step)
        {
            service.Liked(id, step);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost, Route("Save/{id:int}/{step:int}")]
        public HttpResponseMessage Save(int id, int step)
        {
            service.Saved(id, step);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost, Route("Share/{id:int}/{step:int}")]
        public HttpResponseMessage Share(int id, int step)
        {
            service.Shared(id, step);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost, Route("Show/{id:int}/{step:int}")]
        public HttpResponseMessage Show(int id, int step)
        {
            service.Showed(id, step);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
