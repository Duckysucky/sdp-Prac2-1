using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        string out1="";
        string out2="";
        string out3="";
        [SetUp]
        public void Setup()
        {
            
            out1 = Program.Prefix("hello");
            out2 = Program.Prefix("");
            out3 = Program.Prefix("what ... did you say?? ");
        }

        [Test]
        public void Test1()
        {
           Assert.AreEqual("5,1:hello", out1);           
        }
        public void Test2()
        {
            Assert.AreEqual("0,0:", out2);
        }
        public void Test3()
        {
            Assert.AreEqual("what ... did you say?? ", out3);
        }
    }
}
