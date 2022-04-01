using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApp2{

    public class Patty : IComponent
    {
        public string getBurgerPart()
        {
            return "Patty";
        }
    }


}