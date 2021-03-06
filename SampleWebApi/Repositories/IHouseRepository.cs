using System.Collections.Generic;
using SampleWebApi.Models;

namespace SampleWebApi.Repositories
{
    public interface IHouseRepository
    {
        List<HouseEntity> GetAll();
        HouseEntity GetSingle(int id);
        HouseEntity Add(HouseEntity toAdd);
        HouseEntity Update(HouseEntity toUpdate);
        void Delete(int id);
    }
}
