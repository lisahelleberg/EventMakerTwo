using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMakerTwo.Model
{
    class Event
    {
        public int Id;
        public string Name;
        public string Description;
        public string Place;
        public DateTime DateTime;

        public Event()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
