using System;

namespace Breakoutsession1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Computer comp = new Computer();
            Phone ph = new Phone();
            comp.Test();
            ph.Test();
            
        }
    }

	public interface IMachine
    {
        public string Motherboarding();
        public string CPU();
        public string RAM();

    }

    public interface IHardDrive
    {
        public string WritingData();
    }
    public interface IPowerSupply
    {
        public string ProducePower()
        {
            return "Producing Power";
        }

    }

    public interface Iscreen
    {
        public string ScreenShowing();
    }

    public interface IBattery
    {
        public string Battery();
    }
    public class Computer : IMachine, IHardDrive
	{
	
		public Computer()
		{
			
		}

        public string CPU()
        {
            return "Calculating";
        }

        public string Motherboarding()
        {
            return "Connecting everything";
        }

        public string RAM()
        {
            return "Storing Data";
        }
        public string WritingData()
        {
            return "Writing Data";
        }

        public void Test()
        {
            Console.WriteLine("COMPUTER");
            Console.WriteLine(Motherboarding());
            Console.WriteLine(CPU());
            Console.WriteLine(RAM());
            Console.WriteLine(WritingData());
        }

        
    }

    public class Phone : IMachine, Iscreen, IBattery
    {
        public string Battery()
        {
            return "Has Battery";
        }

        public string CPU()
        {
            return "Calculating";
        }

        public string Motherboarding()
        {
            return "Connecting everything";
        }

        public string RAM()
        {
            return "Storing Data";
        }

        public string ScreenShowing()
        {
            return "ScreenShowing";
        }

        public void Test()
        {
            Console.WriteLine("PHONE");
            Console.WriteLine(Motherboarding());
            Console.WriteLine(CPU());
            Console.WriteLine(RAM());
            Console.WriteLine(ScreenShowing());
            Console.WriteLine(Battery());
        }
    }





}
