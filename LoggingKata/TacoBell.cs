using System;
using System.Collections.Generic;
using System.Text;

namespace LoggingKata
{
    internal class TacoBell : ITrackable

    {
        public string Name { get; set; }
        Point Location { get; set; }
    }
}
