using System;

namespace CarWashingFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            carWashingFacade facade = new carWashingFacade();
            facade.WashCars();
        }
    }
}
