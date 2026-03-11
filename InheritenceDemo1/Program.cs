namespace InheritanceDemo
{

    class ElectricalDevice // base or parent class
    {
        // private bool isOn;
        // private string brand; 
        public bool IsOn { get; set; }

        public string Brand { get; set; }


        public void SwitchOn()
        {
            IsOn = true;
            System.Console.WriteLine("Device turned on");

        }
        public void SwitchOff()
        {
            IsOn = false;
            System.Console.WriteLine("Device turned off");
        }
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }


    }
    class Radio : ElectricalDevice // child class
    {

        public void ListenRadio()
        {
            if (IsOn)
            {
                System.Console.WriteLine("Listening to radio!");
            }
            else
            {
                System.Console.WriteLine("Turn on radio first to listen");
            }
        }
        public Radio(bool isOn, string brand) : base(isOn, brand)
        {

        }
    }

    class TV : ElectricalDevice
    {
        public void WatchTV()
        {
            if (IsOn)
            {
                System.Console.WriteLine("Watching TV!");
            }
            else
            {
                System.Console.WriteLine("Turn on the TV first to watch");
            }
        }
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Toshiba");
            System.Console.WriteLine($"Brand of my radio is {myRadio.Brand}");
            myRadio.SwitchOn();
            myRadio.ListenRadio();
            myRadio.SwitchOff();
            myRadio.ListenRadio();




        }
    }
}