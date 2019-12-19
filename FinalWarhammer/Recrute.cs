using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWarhammer
{
    public class Recrute
    {
        private string _RecuitID, _RecuitName, _price, _Health, _Speed, _Attack, _Defence, _PicName;

        public Recrute() { }

        public Recrute( string n, string p, string h, string s, string a, string d, string Picn)
        {
            _RecuitName = n;
            _price = p;
            _Health = h;
            _Speed = s;
            _Attack = a;
            _Defence = d;
            _PicName = Picn;

        }

        public Recrute(string ID, string n, string p, string h, string s, string a, string d, string Picn) {
            _RecuitID = ID;
            _RecuitName = n;
            _price = p;
            _Health = h;
            _Speed = s;
            _Attack = a;
            _Defence = d;
            _PicName = Picn;

        }

        public string RecuitID { get => _RecuitID; set => _RecuitID = value; }
        public string RecuitName { get => _RecuitName; set => _RecuitName = value; }
        public string Price { get => _price; set => _price = value; }
        public string Health { get => _Health; set => _Health = value; }
        public string Speed { get => _Speed; set => _Speed = value; }
        public string Attack { get => _Attack; set => _Attack = value; }
        public string Defence { get => _Defence; set => _Defence = value; }
        public string PicName { get => _PicName; set => _PicName = value; }
    }
}
