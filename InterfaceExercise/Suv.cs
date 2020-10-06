using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Suv : IVehicle , ICompany
    {

        //IVehicle properties
        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Rodeo";
        public string Make { get; set; } = "Izuzu";
        public int SeatCount { get; set; } = 4;
        public bool HasCargoBed { get; set; } = true;
        public bool HasHeatedSeats { get; set; } = true;
        public bool HasChangedGears { get; set; } = true;
        public bool HasFourWheelDrive { get; set; } = true;

        //ICompany properties
        public string CompanyName { get; set; }
        public string Motto { get; set; }

        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
       

        public void Drive()
        {
            if (HasFourWheelDrive == true)
            {
                Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward!");
            }
            else
            {
                Console.WriteLine($"{GetType().Name} now driving forward ...");
            }

        }
        public void Reverse()
        {
            if (HasChangedGears == true)
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
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park ...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park till we change gears!");
            }
              

        }
       
        
            
        


    }
}
