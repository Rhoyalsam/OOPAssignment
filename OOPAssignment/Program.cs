namespace ASSIGNMENT
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Vehicle toyota = new Vehicle();
            toyota.IsdriversLicense = true;
            toyota.IssafetyInspection = true;
            toyota.IsinsuranceInfo = true;
            toyota.vehicleColor = "blue";

            Bigcar bigcar = new Bigcar();
            bigcar.Name = " SUV ";
            bigcar.Description = "V6 Engine";



            Console.WriteLine("please input your name");
            string name = Console.ReadLine();
            Console.WriteLine("please input your vehicle type");
            string description = Console.ReadLine();
            Console.WriteLine(toyota.FirstStep());
            Console.WriteLine(toyota.Next());
            Console.WriteLine(toyota.AlmostThere());
            Console.WriteLine(toyota.FinalStep());

            Console.ReadLine();
        }

    }
}