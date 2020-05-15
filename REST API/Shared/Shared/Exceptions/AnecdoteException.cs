using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Exceptions
{
    [Serializable]
    public class AnecdoteException : Exception
    {
        public HttpStatusCode StatusCode { get; private set; }

        public AnecdoteException(string message, HttpStatusCode _httpStatusCode) : base(message)
        {
            StatusCode = _httpStatusCode;
        }

        public HttpResponseMessage HttpResponseMessage()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(Message),
                StatusCode = StatusCode
            };
        }
    }
}
