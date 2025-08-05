using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop.console
{
    /// <summary>
    /// A class blueprint for a car in our application
    /// </summary>
    public class Car
    {
        private string _make;

        private string _model;

        public string Make { get { return _make; } set { _make = value; } }
        public string Model { get => _model; set => _model = value; }
        public string Description { get { return $"{_make} {_model}"; } } 
        public int WheelCount = 0;
    }
}
