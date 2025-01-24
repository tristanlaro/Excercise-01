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
        private string _Model;
        private string _SerialNumber;
        private int _Weight;

        public int HorsePower
        {
            get { return _HorsePower; }
            set { _HorsePower = value; }
        }

        public bool InService
        { get; set; }
                            
        

        public string Model
        {
            get { return _Model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The title is required!");
                }
                _Model = value.Trim();
            }
        }

        public string SerialNumber
        {
            get { return _SerialNumber; }
            set { _SerialNumber = value; }
        }

        public int Weight
        {
            get { return _Weight; }
            set { _Weight = value; }
        }

        public Engine(string model, string serialnumber, int weight, int horsepower)
        {
            Model = model;
            SerialNumber = serialnumber;
            Weight = weight;
            HorsePower = horsepower;
        }

        public override string ToString()
        {
            return $"{Model},{SerialNumber},{Weight},{HorsePower}";
        }

    }
}
