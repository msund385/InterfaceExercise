using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle , ICompany

    {
        public double EngineSize { get; set; } = 4.6;
        public string Model { get; set; } = "Ford";
        public string Make { get; set; } = "F150";
        public int SeatCount { get; set; } = 4;
        //ICompany properties
        public string CompanyName { get; set; } = "Ford";
        public string Motto { get; set; } = "Built Ford Tough";
        public bool HasChangedGears { get; set; } = true;
        public bool HasFourWheelDrive { get; set; } = true;
       
       

        // Car properties
        public void Drive()
        {
            if(HasFourWheelDrive == true)
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
            if(HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} is now in park ...");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park till we change gears!");
            }

        }
        public void ChangedGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }

    }
}
