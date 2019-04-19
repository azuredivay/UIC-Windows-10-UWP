using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIC_Student.Models
{
    public class Floor
    {
        private readonly string name;
        private readonly string floorcode;
        private readonly ushort floorNum;
        private readonly ushort floorID; //do we need it?
        private List<Room> rooms;

        public List<Room> GetRooms() => rooms;
        public ushort GetNumOfFloors() => floorNum;
        public string GetFloorCode() => floorcode;
        public void FillRooms(List<Room> _rooms)
        {
            foreach (Room r in _rooms) rooms.Add(r);
        }

    }
}
