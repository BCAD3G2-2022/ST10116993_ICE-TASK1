using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApp2{

public class DrinkFactory{
  ICoolDrinks returnInstance;
  public  ICoolDrinks getDrinks(string getDrinkType){
     switch(getDrinkType){
      case("Coke"):
           returnInstance = new Coke();
           break;
           case("Fanta"):
           returnInstance = new Fanta();
            break;
           case("Stoney"):
           returnInstance = new Stoney();
           break;
           

        }
        return returnInstance;

    } 
  }


}





