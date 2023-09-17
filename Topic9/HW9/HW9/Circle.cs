namespace HW9
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(string name, double radius) : base(name)
        {
            this.radius = radius;
        }

        public double Radius { get { return radius; } }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

}