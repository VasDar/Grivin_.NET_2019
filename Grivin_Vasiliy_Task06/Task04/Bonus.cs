namespace Task04
{
    class Bonus : Mov
    {
        public Bonus(int coordinateX, int coordinatey) : base(coordinateX, coordinatey) { }
        public bool cherry { get; set; }
        public bool appel { get; set; }
        public bool goold { get; set; }

        public void locationBonus(double Widht, double Height)
        {
            //раскидываем бонусы по координатам
        }
        public override void Draw()
        {
            //отображаем бонусы на карте
        }
    }

}
