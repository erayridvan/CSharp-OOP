namespace RawData
{
    public class Engine
    {
        public Engine(int engine, int power)
        {
            this.speed = engine;
            this.power = power;
        }

        public int speed { get; set; }

        public int power { get; set; }
    }
}
