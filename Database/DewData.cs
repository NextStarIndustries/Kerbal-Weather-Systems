﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database
{
    //this is a DewData, on Earth, the dew is water, on Mars, it's CO2
    public class DewData
    {
        public string name; //common name of substance
        public string formula; //chemical equation

        //if temp is over 304k
        public float A1;
        public float B1;
        public float C1;

        //if temp isn't over 304k
        public float A2;
        public float B2;
        public float C2;

        public float M; //molar mass of dew

        public float cg; //specific heat capacity of gas
        public float cl; //specific heat capacity of liquid
        public float cs; //specific heat capacity of solid

        public float he; //latent heat evaporation
        public float hm; //latent heat melting
        public float hs; //latent heat sublimination

        public float Dl; //density of dew as a liquid
        public float Ds; //density of the dew as a solid

        public float ks; //thermal conductivity as a gas

        public float T_fr; //freezing temp at 1bar
        public float T_m; //melting temp at 1bar
        public float T_b; //boiling temp at 1bar

        public float n1; // refractive index (real part)
        // public float Xi_SW; // refractive index (imaginary part, visible band)
        // public float Xi_IR; // refractive index (imaginary part, IR band)

        public float a_VdW; // average attraction between particles (Van der Waals equation)
        public float b_VdW; // volume excluded by a mole of particles (Van der Waals equation)

        //public float specificHeatDewSub; //the specific heat of the dewing substance, ie. Earth/kerbin would dew water
    }
}
