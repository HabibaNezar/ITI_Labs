using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_lab
{
    internal class Track
    {
        public int TrackId { get; set; }
        public string TrackName { get; set; }

        public override string ToString()
        {
            return $"TrackId: [{TrackId}] | TrackName:{TrackName}";
        }
    }
}
