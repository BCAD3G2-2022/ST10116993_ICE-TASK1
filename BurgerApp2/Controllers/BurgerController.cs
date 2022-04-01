using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApp2{
public class BurgerController : ControllerBase
{

[HttpGet]
public List<burger> Get(string burgerType ="plain" )
{
    BurgerFactory bf = new BurgerFactory();
    Iburger burger = bf.getBurger(burgerType);
    List<burger> returnbuger = new List<burger>();
    returnbuger.Add(new burger{patty = burger.GetPatty(), buns = burger.GetBuns()});

    return returnbuger;
}

}


}
