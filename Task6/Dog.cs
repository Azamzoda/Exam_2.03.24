

public class Dog : Animal
{

    public Dog(string name)
    {
        
    }
    public override void Greets()
    {
        System.Console.WriteLine("Woof");
    }
    public virtual void Greets1(Dog another)
    {
        System.Console.WriteLine("Woooof");
    }

}