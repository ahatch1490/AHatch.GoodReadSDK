using System.IO;

namespace AHatch.GoodReadsSDK.Test.fixture
{
    public class FixtureDataLoader
    {
        public class StubDataLoader
        {
            public static string LoadJsonFile(string filename)
            {
                var dir = Path.Combine( $"Fixtures/{filename}");
                return File.ReadAllText(dir);
            }
        }
    }
}