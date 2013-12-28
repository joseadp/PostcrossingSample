using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PostcrossingSample.Models;

namespace PostcrossingSample.Controllers
{
    public class PostcardsController : ApiController
    {
        static readonly IPostcardRepository repository = new PostcardRepository();

        public IEnumerable<Postcard> GetAllPostcards()
        {
            return repository.GetAll();
        }
    }
}
