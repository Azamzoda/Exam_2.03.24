
public class BigDog : Dog
{
   

    public BigDog(string name) : base (name)
    {
        _name = name;        
    }
    public override void Greets()
    {
        System.Console.WriteLine("Wooow");
    }
    public override void Greets1(Dog another)
    {
        System.Console.WriteLine("Wooooow");
    }
    public void Greets2(BigDog another)
    {
        System.Console.WriteLine("Wooooooow");
    }
}