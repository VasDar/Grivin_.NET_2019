namespace Task04
{
    class Player : Mov
    {
        public Player(int coordinateX, int coordinateY) : base(coordinateX, coordinateY) { }

        public string name;
        public string satus { get; set; } // передает статус игрока 
        public double health;

        public override void Draw()
        {
            //отображаем бонусы на карте
        }
        public bool Collect(int coordinateX, int coordinateY)
        {
            bool value = true;
            return value;
        }
    }

}
