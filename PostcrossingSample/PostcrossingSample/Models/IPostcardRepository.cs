using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostcrossingSample.Models
{
    interface IPostcardRepository
    {
        IEnumerable<Postcard> GetAll();
        Postcard Get(int id);
        Postcard Add(Postcard item);
        void Remove(int id);
        bool Update(Postcard item);
    }
}