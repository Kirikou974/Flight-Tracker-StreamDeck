﻿using System;

namespace FlightStreamDeck.Core
{
    public class ToggleValue: BaseToggle
    {
        public const string DEFAULT_UNIT = "number";
        public const int DEFAULT_DECIMALS = 0;
        public ToggleValue(string name, string unit, int? decimals, double? minValue, double?  maxValue): base(name)
        
        {
            Decimals = decimals;
            Unit = unit;
            //MinValue = minValue;
            //MaxValue = maxValue;
        }
        public ToggleValue(string name, string unit, int? decimals) : this(name, unit, decimals, null, null)
        
        {
           if (name == "COM_ACTIVE_FREQUENCY__1")
           {
               Decimals = 3;
               Unit = "Mhz";
           }
           else if (name == "COM_STANDBY_FREQUENCY__1")
           {
                Decimals = 3;
                Unit = "Mhz";
           }
           else if (name == "COM_ACTIVE_FREQUENCY__2")
           {
                Decimals = 3;
                 Unit = "Mhz";
           }
            else if (name == "COM_STANDBY_FREQUENCY__2")
           {
                Decimals = 3;
                Unit = "Mhz";
            }
            else
            {
                Decimals = decimals;
                Unit = unit;
            }

        }
        public ToggleValue(string name): this(name, DEFAULT_UNIT, DEFAULT_DECIMALS)
        {

        }
        public ToggleValue(string name, string unit) : this(name, unit, DEFAULT_DECIMALS)
        {
            Unit = unit;
        }

        public double Value
        {
            get;
            set;
        }

        public int DefineID
        {
            get;
            set;
        }

        public double? MinValue
        {
            get;
            set;
        }
        public double? MaxValue
        {
            get;
            set;
        }

        public int? Decimals
        {
            get;
            set;
        }

        public string Unit
        {
            get;
            set;
        }
    }
}
