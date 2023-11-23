
namespace ConsoleApp1
{
    internal class NewClass : INewInterface
    {
        public int DoNewWork()
        {
            Console.WriteLine("NewClass.DoNewWork()");

            return 1;
        }
    }
}
