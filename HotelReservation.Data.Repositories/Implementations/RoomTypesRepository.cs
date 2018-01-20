using System;
using System.Collections.Generic;
using HotelReservation.Models.Entities;
using HotelReservation.Data.Common;

namespace HotelReservation.Data.Repositories.Implementations
{
    public class RoomTypesRepository : IRoomTypesRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public RoomTypesRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<RoomType> GetAllRoomTypes()
        {
            throw new NotImplementedException();
        }

        public RoomType GetRoomType()
        {
            throw new NotImplementedException();
        }
    }
}
