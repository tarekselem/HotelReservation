using HotelReservation.Data.Common;
using HotelReservation.Data.Repositories.Implementations;
using HotelReservation.Data.Repositories.Interfaces;
using HotelReservation.Models.Entities;
using Unity;

namespace HotelReservation.Bo
{
    public static class UnityConfiguration
    {
        private static UnityContainer _container;
        public static UnityContainer Container => _container ?? (_container = new UnityContainer());

        public static void RegisterTypes()
        {
            Container.RegisterType<IRepository<DtoRoom>, RoomRepository>();
            Container.RegisterType<IRepository<DtoRoomType>, RoomTypeRepository>();
            Container.RegisterType<IRepository<DtoGuest>, GuestRepository>();
            Container.RegisterType<IRepository<DtoReservation>, ReservationRepository>();
        }
    }
}
