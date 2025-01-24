﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TrainSystem
{
    public class Engine
    {
        private int _HorsePower;
        private string _Model;
        private string _SerialNumber;
        public int _Weight;
        private bool _InService = true;

        public int HorsePower
        {
            get { return _HorsePower; }
            set {
                if (value <= 0 )
                {
                    throw new ArgumentOutOfRangeException("All weights must be a positive number and in increments of 100!");
                }
                _HorsePower = value; }
        }

        public bool InService
        {
            get { return _InService;  }
            set
            {
                if (value != true && value != false)
                {
                    throw new InvalidOperationException("The service state must be a valid boolean value.");
                }

                // Allow state change if it's different from the current value
                if (_InService == value)
                {
                    throw new InvalidOperationException("The service state must change to a valid value.");
                }

                _InService = value;
            }
        }


        public  string Model
        {
            get { return _Model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The Model is required, space can not be blank!");
                }
                _Model = value.Trim();
            }
        }

        public string SerialNumber
        {
            get { return _SerialNumber; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("The Serial Number is required!");
                }
                _SerialNumber = value.Trim();}
        }

        public int Weight
        {
            get { return _Weight; }
            set {
                if (value <= 0 || value % 100 != 0  )
                {
                    throw new ArgumentException("All weights must be a positive number and in increments of 100!");
                }
                
                _Weight = value; }
        }

        public Engine(string model, string serialnumber, int weight, int horsepower)
        {
            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException("Model cannot be null or whitespace");

            if (string.IsNullOrWhiteSpace(serialnumber))
                throw new ArgumentNullException("Serial Number cannot be null or whitespace");

            if (weight <= 0 || weight % 100 != 0)
                throw new ArgumentOutOfRangeException("Weight must be a positive, non-zero number in 100-pound increments.");

            if (horsepower <= 0)
                throw new ArgumentOutOfRangeException("HorsePower must be a positive number.");


            Model = model.Trim();
            SerialNumber = serialnumber.Trim();
            Weight = weight;
            HorsePower = horsepower;
            
        }

        public override string ToString()
        {
            return $"{Model},{SerialNumber},{Weight},{HorsePower},{InService}";
        }

    }
}
