using System.Collections.Generic;
using HotelReservation.Models.Entities;

namespace HotelReservation.Bo
{
    public class BoGuest : BoBase<DtoGuest>
    {
        public DtoGuest Create(string name, string email, string phone)
        {
            var dtoGuest = new DtoGuest
            {
                Name = name,
                Email = email,
                Phone = phone
            };
            Repository.Insert(dtoGuest);
            return dtoGuest;
        }

        public IEnumerable<DtoReservationStatus> Browse(DtoReservation reservation)
        {
            return reservation.ReservationStatusList;
        }
    }
}