namespace MyLibrary
{
    public class Animal : IAnimal
    {
        public string race { get; set; }
        public Animal(string race)
        {
            this.race = race;
        }
public bool isDog()
        {
            return this.race.Equals("dog");
        }
    }
}