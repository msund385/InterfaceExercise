using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{


    class Car : IVehicle, ICompany
    {
        //IVehicle propertie
        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "Mustang";
        public int SeatCount { get; set; } = 4;
        //ICompany properties
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; } = true;


        // Car properties
         public void Drive()
         {
            Console.WriteLine($"{GetType().Name} now driving forward!");
         }
         public void Reverse()
         {
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing....");
                  HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse until we change gears");
            }
           
         }
         public void Park()
        {


        }
        public void ChangedGears(bool isChanged)
        {
             HasChangedGears = isChanged;
        }
           











    }

}   








    

        
     
        

        

