using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BFFExample.Routes
{
    public class CarsMS
    {

        private static String url = "http://localhost:62828/";
        public readonly String getCars = url + "cars";
    }
}
