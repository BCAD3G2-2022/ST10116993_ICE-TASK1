using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace BurgerApp2{
public class CheeseBurger : Iburger
 {

  public string GetCheese(){
      return "Cheese";
}

 public string GetPatty(){  
 return "Patty";
}

public string GetBuns(){
    return "Buns"; 
}  

}

}




