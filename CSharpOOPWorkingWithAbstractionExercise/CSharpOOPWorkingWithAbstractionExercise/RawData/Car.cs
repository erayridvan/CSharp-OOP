﻿using System.Collections.Generic;

namespace RawData
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Cargo = cargo;
            this.Engine = engine;
            this.Tires = tires;
        }
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }
    }
}
