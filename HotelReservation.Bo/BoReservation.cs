using System;
using HotelReservation.Models.Entities;

namespace HotelReservation.Bo
{
    public class BoReservation : BoBase<DtoReservation>
    {
        public BoReservation()
        {
             
        }
        public void Book(DtoReservation reservation)
        {
            // roles: 
            // number of days must be more than number of cancelation days fees
        }
        public void Checkout(DtoReservation reservation)
        {
            // roles: 
            // mark reservation as checkedout
            // Hotel write down remaining amount to the Guest Account

        }
        public void CheckIn(DtoReservation reservation)
        {
            //Marks that reservation as "Checked in"
        }

        public void Cancel(DtoReservation reservation)
        {
            //hotel posts a cancellation fee to the Guest Account
        }

    }
}
