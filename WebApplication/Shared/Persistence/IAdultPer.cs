using System.Collections.Generic;
using WebApplication.Shared.Models;

namespace WebApplication.Shared.Persistence
{
    public interface IAdultPer
    {
        void AddAdult(Adult adult);
        List<Adult> GetAllAdults();
        void RemoveAdult(int id);

        Adult GetAdultById(int id);
        void EditAdult(Adult adult);
    }
}