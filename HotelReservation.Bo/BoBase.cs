using HotelReservation.Data.Common;
using Unity;

namespace HotelReservation.Bo
{
    public class BoBase<TEntity>
    {
        public UnityContainer UnityContainer;
        public IRepository<TEntity> Repository;
        public BoBase()
        {
            UnityContainer = UnityConfiguration.Container;
            Repository = UnityContainer.Resolve<IRepository<TEntity>>();
        }
    }
}
