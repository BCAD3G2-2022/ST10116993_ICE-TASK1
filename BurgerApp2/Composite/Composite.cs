using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BurgerApp2{
    public class Composite : IComponent
    {
        string part;

        public Composite(string part){
            this.part = part;
        }
        List<IComponent> components = new List<IComponent>();
        public  string getBurgerPart()
        {
           for(int i =0;i<components.Count;i++){
               part = components.ElementAt(i).getBurgerPart();
           } 

           return part;
        }

        public void addPart(IComponent component){
            components.Add(component);
        }

         
         public void removePart(IComponent component) {
             components.Remove(component);
         } 

         public  string getPart()
         {
             string part = null;
             for(int i =0 ; i <components.Count;i++)
             {
               part += components.ElementAt(i).getBurgerPart();
             }
             return part;
         }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
    }
}       