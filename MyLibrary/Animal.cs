namespace MyLibrary
{
    public class Animal : IAnimal
    {
        public string race { get; set; }
        public Animal(string race)
        {
            this.race = race;
        }
    }
}