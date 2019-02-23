using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        string out1="";
        string out2="";
        string out3="";
        string out4="";
        string out5="";
        string out6="";
        [SetUp]
        public void Setup()
        {
            
            out1 = Program.Prefix("hello");
            out2 = Program.Prefix("");
            out3 = Program.Prefix("what ... did you say??");
            out4 = Program.Prefix("you dont know jack");
            out5 = Program.Prefix("moo");
            out6 = Program.Prefix("the cow goes baa");
        }

        [Test]
        public void Test1()
        {
           Assert.AreEqual("5,1:hello", out1);
           Assert.AreEqual("0,0:", out2);  
           Assert.AreEqual("22,5:what ... did you say??", out3);
           Assert.AreEqual("18,4:you dont know jack", out4);
           Assert.AreEqual("3,1:moo", out5);
           Assert.AreEqual("16,4:the cow goes baa", out6);         
        }
    }
}
