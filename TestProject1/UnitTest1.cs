
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Assert = NUnit.Framework.Assert;
using  Kek2;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            double a = 1;
            double b = -4;
            double c = 4;
            var p = new Class();
            
            List<double> roots = Class.SolveQuadraticEquation(a, b, c);
            List<double> expected_roots = new List<double> { 2 };
            Assert.AreEqual(0, 0); // to check that we are ready to test

            Assert.AreEqual(roots.Count, expected_roots.Count);

            Assert.AreEqual(roots.First(), expected_roots.First());
        }
    }
}