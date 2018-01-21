using System;
using HotelReservation.Models.Entities;

namespace HotelReservation.Bo
{
    public class BoReservation : BoBase<DtoReservation>
    {
        public DtoReservation Book(DtoGuest dtoGuest, DtoRoom dtoRoom, DateTime arrivalData, DateTime departureDate)
        {
            // roles: 
            // number of days must be more than number of cancelation days fees
            var dtoReservation = new DtoReservation
            {
                ArrivalDate = arrivalData,
                DepartureDate = departureDate,
                Guest = dtoGuest,
                Room = dtoRoom,
            };
            var fees = 100 / (dtoReservation.Room.RoomType.DepositFeePercentage) + dtoReservation.Room.RoomType.Rate;
            dtoReservation.AddReservationStatus(new DtoReservationStatus{ReservationStatus = ReservationStatus.Booked, Fees = fees});
            Repository.Insert(dtoReservation);
            return dtoReservation;
        }
        public void Checkout(DtoReservation reservation)
        {
            // roles: 
            // mark reservation as checkedout
            // Hotel write down remaining amount to the Guest Account
            reservation.AddReservationStatus(new DtoReservationStatus{ReservationStatus = ReservationStatus.CheckedOut});
            Repository.Update(reservation);
        }
        public void CheckIn(DtoReservation reservation)
        {
            //Marks that reservation as "Checked in"
            reservation.AddReservationStatus(new DtoReservationStatus{ReservationStatus = ReservationStatus.CheckedIn});
            Repository.Update(reservation);
        }

        public void Cancel(DtoReservation reservation)
        {
            //hotel posts a cancellation fee to the Guest Account
            var fees = reservation.Room.RoomType.CancellationFeeNightsCount * reservation.Room.RoomType.Rate;
            reservation.AddReservationStatus(new DtoReservationStatus { ReservationStatus = ReservationStatus.Canceled, Fees = fees});
            Repository.Update(reservation);
        }

    }
}
