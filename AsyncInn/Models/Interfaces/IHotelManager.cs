﻿using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IHotelManager
    {
        Task CreateHotel(Hotel hotel);

        Task UpdateHotel(int id, Hotel hotel);

        Task<Hotel> DeleteHotel(int id);

        Task DeleteHotelFR(int id);


        Task<Hotel> GetHotel(int id);

        Task<IEnumerable<Hotel>> GetHotels();

        bool HotelExists(int id);

        //ICollection<HotelRoom> GetHotelRooms(int hotelId);
    }
}
