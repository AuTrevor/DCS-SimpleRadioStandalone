﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciribob.DCS.SimpleRadio.Standalone.Common.DCSState
{
    public class DCSLatLngPosition
    {
        public DCSLatLngPosition()
        {

        }

        public DCSLatLngPosition(double lat, double lng,double alt)
        {
            this.lat = lat;
            this.lng = lng;
            this.alt = alt;
        }

        public double lat = 0;
        public double lng = 0;
        public double alt = 0;
    }
}
