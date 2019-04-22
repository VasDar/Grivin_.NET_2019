namespace Task04
{
    class Obstacles : Mov
    {
        public Obstacles(int coordinateX, int coordinateY) : base(coordinateX, coordinateY) { }
        public object Trees = new object();
        public object Stones = new object();
        public void locationObstracles(int coordinateX, int coordinateY)
        {
            //раскидываем препятствия по координатам
        }
        public override void Draw() { }
    }

}
