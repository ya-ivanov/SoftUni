﻿using System;

namespace GalacticGPS
{
    class GalacticGPS
    {
        static void Main()
        {
            Location earth = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(earth.ToString());
        }
    }
}
