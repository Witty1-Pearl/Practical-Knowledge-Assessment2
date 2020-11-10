namespace IVehiculoInterface
{

    
    public class  Car : IVehiculo 
    {
        public int StartingGasoline { get; set;}

        public Car(int startingGasoline)
        {
            startingGasoline = startingGasoline;
        }
        public void Drive()
        {
           if (StartingGasoline > 0)
           {
              Console.WriteLine("Car is Driving");
           } else {
               Console.WriteLine("Car needs gas");
           }
        }

        public void Refuel(int startingGasoline)
        {
            if (SartingGasoline > 0)
            {
                
            }
        }


        public bool Refuel(int amountOfGasoline)
        {
            if (gasoline > 0)
            {
                
            }
        }
    }
}