public class AcessModifier
{
    internal void DoSomething()
    {

    }

   public void DoAnother()
    {

    }
}

class ModifierDemo
{
    void hero()
    {
        AcessModifier acess = new AcessModifier();
        acess.DoSomething();
    }
}