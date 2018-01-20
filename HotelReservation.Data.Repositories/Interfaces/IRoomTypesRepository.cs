using System.Collections.Generic;

namespace HotelReservation.Data.Repositories
{
    public interface IRoomTypesRepository
    {
        IEnumerable<Models.Entities.RoomType> GetAllRoomTypes();
        Models.Entities.RoomType GetRoomType();
    }
}
