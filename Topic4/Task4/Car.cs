  class Car
    {
	public const string MARK = "BMW";
        public string name;
        private string color;
	public string Color
        {
            set { color = value; }
            get { return color; }
        }
        public double price;
        public Car()
        {
           
        }
        public Car(string name, string color, float price)
        {
            this.name = name;
            this.color = color;
            this.price = price;
        }
        
        public void Input()
        {
            Console.Write("Enter the name ");
            name = Console.ReadLine();
            Console.Write("Enter the color ");
            color = Console.ReadLine();
            Console.Write("Enter the price ");
            price = Convert.ToInt32(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("car name "+name+"\ncar color "+color+"\ncar price "+price);
        }

        public void ChangePrice(double x)
        {
            price -= price* x / 100;
        }

        public static bool operator ==(Car first, Car second)
        {
            return (first.name==second.name)&&(first.price==second.price);
        }

        public static bool operator !=(car first, car second)
        {
            return !(first.name == second.name) && (first.price == second.price);
        }

        public override string ToString()
        {
            return "car name " + name + "\ncar color " + color + "\ncar price " + price;
        }
    }
}
