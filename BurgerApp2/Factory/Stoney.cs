using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BurgerApp2{

public class Stoney : ICoolDrinks{
public string getdName(){
    return "Stoney";
}

public string getdPrice(){
    return "18";
}

}




}