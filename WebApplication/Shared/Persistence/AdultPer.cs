using System;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Shared.Models;

namespace WebApplication.Shared.Persistence
{
    public class AdultPer : IAdultPer
    {
        private FileContext _fileContext;

        public AdultPer(FileContext fileContext)
        {
            _fileContext = fileContext;
        }

        public void AddAdult(Adult adult)
        {
            if (adult == null) throw new NullReferenceException("Adult must not be null");
        
            try
            {
                Adult exists = _fileContext.Adults.FirstOrDefault(a => a.Equals(adult));
                if (exists != null) throw new ArgumentException("Adult aready exists");
                int newId = _fileContext.Adults.Max(person => person.Id);
                adult.Id = ++newId;
                _fileContext.Adults.Add(adult);
                _fileContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public List<Adult> GetAllAdults()
        {
            return _fileContext.Adults.ToList();
        }

        public void RemoveAdult(int id)
        {
            Adult adult = _fileContext.Adults.FirstOrDefault(a => a.Id.Equals(id));
            _fileContext.Adults.Remove(adult);
            _fileContext.SaveChanges();
        }

        public Adult GetAdultById(int id)
        {
            Adult adultToReturn = _fileContext.Adults.FirstOrDefault(a => a.Id.Equals(id));
            if (adultToReturn == null) throw new Exception("Adult does not exist!");
            return adultToReturn;
        }

        public void EditAdult(Adult adult)
        {
            _fileContext.Adults[_fileContext.Adults.ToList().FindIndex(index => index.Id.Equals(adult.Id))] = adult;
            _fileContext.SaveChanges();
        }
    }
}