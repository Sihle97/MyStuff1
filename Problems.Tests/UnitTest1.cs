using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        
        [Test]
        public void test1()
        {

            Program tester = new Program();
            Assert.AreEqual("5,1:hello", tester.Prefix("hello"));
            
        }

        [Test]
        public void test2()
        {
            Program tester = new Program();
            Assert.AreEqual("0,0:", tester.Prefix(""));
        }

        [Test]
        public void test3()
        {
            Program tester = new Program();
            Assert.AreEqual("27,5:what    ... did you say??  ", tester.Prefix("what    ... did you say??  "));
        }
    }
}