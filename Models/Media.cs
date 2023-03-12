namespace Assignment6Cottrell.Models
{
    public abstract class Media
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual void Display()
        {
            System.Console.WriteLine($"{Title}");
        }

        //public override string ToString()
        //{
        //    return $"{Title}";
        //}
    }


}
