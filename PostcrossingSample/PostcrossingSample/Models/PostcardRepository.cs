using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PostcrossingSample.Models
{
    public class PostcardRepository : IPostcardRepository
    {
        private List<Postcard> postcards = new List<Postcard>();
        private int _nextId = 1;

        public PostcardRepository()
        {
            Add(new Postcard { CountryCode = "BR", PostcardNumber = 291738, SentDate = DateTime.Parse("26/11/2013"), DestinationCountry = "New Zealand", ToMember = "nadi_" });
            Add(new Postcard { CountryCode = "BR", PostcardNumber = 287975, SentDate = DateTime.Parse("02/11/2013"), DestinationCountry = "Czech Republic", ToMember = "Sachiko-chan" });
        }

        public IEnumerable<Postcard> GetAll()
        {
            return postcards;
        }

        public Postcard Get(int id)
        {
            return postcards.Find(p => p.Id == id);
        }

        public Postcard Add(Postcard item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            item.Id = _nextId++;
            postcards.Add(item);
            return item;
        }

        public void Remove(int id)
        {
            postcards.RemoveAll(p => p.Id == id);
        }

        public bool Update(Postcard item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            int index = postcards.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            postcards.RemoveAt(index);
            postcards.Add(item);
            return true;
        }
    }
}