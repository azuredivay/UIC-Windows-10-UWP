using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIC_Student.Models
{
    public class Professor
    {
        private readonly int iD;
        private readonly string name;
        private readonly string netID;
        private readonly Room office;

        public Professor(int id, string _name, string _netid, Room _office)
        {
            iD = id;
            name = _name;
            netID = _netid;
            office = _office;
        }

        public Room GetOffice() => office;
        public string GetName() => name;
        public string GetNetID() => netID;
        public int GetID() => iD;
        public bool IsInOffice()
        {
            return false; //hold schedule info here?
        }
    }
}
