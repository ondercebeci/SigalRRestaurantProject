using SignalR.BussinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntitiLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BussinessLayer.Concrete
{
    public class FeatureMenager : IFeatureService
    {
        private readonly IFeatureDal _featureDal;

        public FeatureMenager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public void TAdd(Feature Entity)
        {
            _featureDal.Add(Entity);
        }

        public void TDelete(Feature Entity)
        {
            _featureDal.Delete(Entity);
        }

        public Feature TGetByID(int id)
        {
            return _featureDal.GetByID(id);
        }

        public List<Feature> TGetListAll()
        {
            return _featureDal.GetListAll();
        }

        public void TUpdate(Feature Entity)
        {
            _featureDal.Update(Entity);
        }
    }
}
