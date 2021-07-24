using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out_HomeWork
{
    class Palaphone
    {
        public int _screenSize;
        public string _model;
        public string _battery;
        public string _cameraQualety;
        public Palaphone(int screenSize = 5, string model = "iphone", string battery = "good", string cameraQualety = "good")
        {
            _screenSize = screenSize;
            _model = model;
            _battery = battery;
            _cameraQualety = cameraQualety;
        }
    }
}
