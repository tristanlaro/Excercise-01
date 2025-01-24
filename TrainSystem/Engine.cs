using System;
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
        private readonly string _Model;
        private readonly string _SerialNumber;
        public int _Weight;
        private bool _InService = true;

        public int HorsePower
        {
            get { return _HorsePower; }
            set
            {
                if (value <= 3500 || value >= 5500 || value % 100 != 0)
                {
                    throw new ArgumentOutOfRangeException("HorsePower Must be between 3500 and 5500 and in increments of 100!");
                }
                if (_InService)
                {
                    throw new ArgumentException("HorsePower cannot be changed while the engine is in service.");
                }
                _HorsePower = value;
            }
        }

        public bool InService
        {
            get { return _InService; }
            set
            {
                if (value != true && value != false)
                {
                    throw new InvalidOperationException("The service state must be a valid boolean value.");
                }


                if (_InService == value)
                {
                    throw new InvalidOperationException("The service state must change to a valid value.");
                }

                _InService = value;
            }
        }


        public string Model
        {
            get { return _Model; }

        }

        public string SerialNumber
        {
            get { return _SerialNumber; }

        }

        public int Weight
        {
            get { return _Weight; }
            set
            {
                if (value <= 0 || value % 100 != 0)
                {
                    throw new ArgumentException("All weights must be a positive number and in increments of 100!");
                }
                if (_InService)
                {
                    throw new ArgumentException("Weight cannot be changed while the engine is in service.");
                }

                _Weight = value;
            }
        }

        public Engine(string model, string serialnumber, int weight, int horsepower)
        {

            if (string.IsNullOrWhiteSpace(model))
                throw new ArgumentNullException("Model cannot be null or whitespace");

            else if (string.IsNullOrWhiteSpace(serialnumber))
                throw new ArgumentNullException("Serial Number cannot be null or whitespace");

            else if (weight <= 0 || weight % 100 != 0)
                throw new ArgumentOutOfRangeException("Weight must be a positive, non-zero number in 100-pound increments.");

            else if (horsepower <= 3500 || horsepower >= 5500 || horsepower % 100 != 0)
                throw new ArgumentOutOfRangeException("HorsePower Must be between 3500 and 5500 and in increments of 100!");



            _Model = model.Trim();
            _SerialNumber = serialnumber.Trim();
            _Weight = weight;
            _HorsePower = horsepower;


        }

        public override string ToString()
        {
            return $"{Model},{SerialNumber},{Weight},{HorsePower},{InService}";
        }

    }
}
