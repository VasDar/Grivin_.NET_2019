namespace Task01
{
    //линия - line +
    //окружность - circle
    //Прямоугольник - rectangle + 
    //Круг -  round
    //Кольцо - ring

    public class Shape : IDraw
    {
        public double Xcentre { get; set; }
        public double Ycentre { get; set; }
        public string Name { get; set; }
        public Shape(double xcentre, double ycentre, string name)
        {
            Xcentre = xcentre;
            Ycentre = ycentre;
            Name = name;
        }
        public Shape(string name)
        {
            Name = name;
        }
        public Shape(){}



        public virtual void Draw(){}
    }
}
