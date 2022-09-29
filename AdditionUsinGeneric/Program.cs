namespace AdditionUsinGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Addition<int> add = new Addition<int>();
          add.addme(10 ,20);
        }
    }
}