﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AsyncInn.Data;
using AsyncInn.Models;
using AsyncInn.Models.Interfaces;

namespace AsyncInn.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IRoom _context;

        public RoomsController(IRoom context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index(string searchstring)
        {
            IEnumerable<Room> Rooms = await _context.GetRooms();
            var rooms = from m in Rooms
                         select m;
            if (!String.IsNullOrEmpty(searchstring))
            {
                rooms = rooms.Where(s => s.Name.Contains(searchstring));
            }

            return View(rooms);
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int id)
        {


            var room = await _context.GetRoom(id);
            return View(room);

        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,RoomLayout")] Room room)
        {
            if (ModelState.IsValid)
            {
                await _context.CreateRoom(room);
                return RedirectToAction(nameof(Index));

            }
            return View(room);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var room = await _context.GetRoom(id);

            return View(room);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,RoomLayout")] Room room)
        {
            if (id != room.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _context.UpdateRoom(id, room);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(room);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            


            Room room = await _context.DeleteRoom(id);



            

            return View(room);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _context.DeleteRoomFR(id);
            return RedirectToAction(nameof(Index));
        }

        private bool RoomExists(int id)
        {
            return _context.RoomExists(id);
        }
    }
}
