namespace Task04
{
    class Field
    {
        public double Widht;
        public double Height;
        public int CoordinateX;
        public int CoordinateY;
        public Field() { }
        public Field(int coordinateX, int coordinateY)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
        }
        public Field(double widht, double height)
        {
            Widht = widht;
            Height = height;
        }
        public virtual void Draw() { }

    }

}
