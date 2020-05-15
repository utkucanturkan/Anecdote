using Anectode.WebService.Filters;
using BusinessLogicLayer.Abstracts;
using BusinessLogicLayer.ViewModels;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Anectode.WebService.Controllers
{
    [RoutePrefix("api/Anecdote"), AnecdoteExceptionFilter]
    public class AnecdoteController : ApiController
    {
        private readonly IAnecdoteService service;

        public AnecdoteController(IAnecdoteService _service)
        {
            service = _service;
        }

        [HttpGet, Route("Get/{id:int}")]
        public AnecdoteViewModel Get(int id)
        {
            return service.Get(id);
        }

        [HttpGet, Route("GetMostLiked")]
        public IEnumerable<AnecdoteListViewModel> GetMostLiked()
        {
            return service.GetMostLiked();
        }

        [HttpGet, Route("GetNew")]
        public IEnumerable<AnecdoteListViewModel> GetNew()
        {
            return service.GetNew();
        }

        [HttpGet, Route("GetPopular")]
        public IEnumerable<AnecdoteListViewModel> GetPopular()
        {
            return service.GetPopular();
        }

        [HttpGet, Route("Search/{text}")]
        public IEnumerable<AnecdoteListViewModel> Search(string text)
        {
            return service.Search(text);
        }

        [HttpPost, Route("Add")]
        public HttpResponseMessage Add([FromBody] AnecdoteAddViewModel model)
        {
            service.Add(model);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost, Route("Update")]
        public HttpResponseMessage Update([FromBody] AnecdoteUpdateViewModel model)
        {
            service.Update(model);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        [HttpPost, Route("Delete/{id:int}")]
        public HttpResponseMessage Delete(int id)
        {
            service.Delete(id);
            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}
