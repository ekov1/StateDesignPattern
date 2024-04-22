namespace _00._StateMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.TakeAction(Car.Action.Accelerate);
            PrintState(car);
            car.TakeAction(Car.Action.Start);
            PrintState(car);
            car.TakeAction(Car.Action.Start);
            PrintState(car);
            car.TakeAction(Car.Action.Accelerate);
            PrintState(car);
            car.TakeAction(Car.Action.Stop);
            PrintState(car);
        }

        public static void PrintState(Car car)
        {
            Console.WriteLine($"Current state = {car.CurrentState.ToString()}");
        }
    }
}