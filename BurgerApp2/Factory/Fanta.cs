using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApp2{

public class Fanta : ICoolDrinks{

public string getdName(){
    return "Fanta";
}

public string getdPrice(){
    return "17";
}

}




}