using System;
using System.Collections.Generic;
using System.Text;

namespace CarWashingFacade
{
    public class carWashingFacade
    {
        private DryTheCar _DryCar;
        private polishTheCar _polishTheCar;
        private washCarWithiSoap _washCarWithiSoap;
        private washCarWithWater _washCarWithWater;

        public carWashingFacade()
        {
            _DryCar = new DryTheCar();
            _polishTheCar = new polishTheCar();
            _washCarWithiSoap = new washCarWithiSoap();
            _washCarWithWater = new washCarWithWater();
        }

        public void WashCars()
        {
            Console.WriteLine("Cleaning a new car");
            _washCarWithiSoap.setWashCarWithSoap();
            _washCarWithWater.setWashCarWithWater();
            _DryCar.setDryTheCar();
            _polishTheCar.setPolishTheCar();
            Console.WriteLine("Finish with the cleaning of the car");
        }
    }
}
