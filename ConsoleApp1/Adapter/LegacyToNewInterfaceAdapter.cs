
namespace ConsoleApp1.Adapter
{
    internal class LegacyToNewInterfaceAdapter : INewInterface
    {
        private readonly LegacyClass _legacyObj;

        public LegacyToNewInterfaceAdapter(LegacyClass legacyObj)
        {
            this._legacyObj = legacyObj;
        }

        public int DoNewWork()
        {
            Console.Write("Providing a wrapper (LegacyToNewInterfaceAdapter) around the Legacy class ");
            _legacyObj.DoWork();
            return 2;
        }
    }
}
