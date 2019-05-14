using TestNinJa.Mocking;

namespace TestNinja.UnitTest
{
    public class FakeFileReader : IFileReader
    {
        public string Read(string path)
        {
            return "";
        }
    }
}
