namespace SampleNUnitTest
{
    public class SampleUnitTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestVersion()
        {
            string version = SampleNuGetPackage.API.GetVersion();
            Assert.NotNull(version);
        }
    }
}