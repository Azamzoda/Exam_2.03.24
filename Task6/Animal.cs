public abstract class Animal
{
    protected string _name;
    public Animal(){}
    public Animal(string name)
    {
        _name = name;
    }
    public abstract void  Greets();
}