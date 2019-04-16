using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
//using System.Device.Location; //not in UWP?
namespace UIC_Student.Models
{
    public class Room
    {
        private readonly string roomCode;
        private readonly Floor floor;
        private readonly Building building;
        private readonly string type; //change to enum?
        private readonly Geocoordinate location;

        public Room(string _roomcode, Floor _floor, Building _building, string _type, Geocoordinate _latlon)
        {
            roomCode = _roomcode;
            floor = _floor;
            building = _building;
            type = _type;
            location = _latlon;
        }

        public Tuple<Floor, Building> GetFloorNBuilding() => new Tuple<Floor, Building>(floor, building);

        public Geocoordinate GetLocation() => location;

        public string GetRoomType() => type;

        //public double GetDistanceTo(Geocoordinate loc) => location.GetDistanceTo(loc); //get distance unavable in W.D.G
    }
}
