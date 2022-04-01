using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApp2{

public class CoolDrinksController : ControllerBase{

[HttpGet]

public List<cooldrinks>  Getd(string getDrinkType = "Coke"){
DrinkFactory df = new DrinkFactory();
ICoolDrinks cdrinks =df.getDrinks(getDrinkType);
 List<cooldrinks> returndrink = new List<cooldrinks>();
 returndrink.Add(new cooldrinks{dName = cdrinks.getdName(),dPrice =  cdrinks.getdPrice()});
return  returndrink;
}

}


}