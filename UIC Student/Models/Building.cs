using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace UIC_Student.Models
{
    public class Building
    {
        private readonly string name;
        private readonly Geocoordinate location;
        private readonly string caption;
        private readonly int pin; //60607 ish
        private readonly string buildingAbvr; //UH/JST ish
        private readonly string buildingCode; //0601 ish
        private string type; //parking 
        private List<Floor> floors; //should store rooms too?

        public Building(string _name, Geocoordinate _loc, int _pin, string _abvr, string _bcode, string _type)
        {
            name = _name;
            location = _loc;
            pin = _pin;
            buildingAbvr = _abvr;
            buildingCode = _bcode;
            type = _type;
        }

        public void FillFloors(List<Floor> _floors)
        {
            foreach (Floor fl in _floors) floors.Add(fl);
        }

        public string GetName() => name;
        public string GetBAbvr() => buildingAbvr;
        public string GetBCode() => buildingCode;
        public string GetBlType() => type;
        public Geocoordinate GetLocation() => location;
        public List<Floor> GetFloors() => floors;
    }
}
