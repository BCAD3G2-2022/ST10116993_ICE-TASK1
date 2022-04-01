using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApp2{
 
public class BurgerFactory{ 
     public Iburger returnInstance;
    public Iburger getBurger(string burgerType){
switch(burgerType){
      case("VegieBurger"):
           returnInstance = new Vegie_Burger();
           break;
           case("Double Patty"):
           returnInstance = new Double_Pattys();
            break;
           case("cheese"):
           returnInstance = new CheeseBurger();
           break;
           

        }
        return returnInstance;

    }
}


}
