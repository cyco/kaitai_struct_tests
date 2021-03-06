using NUnit.Framework;

namespace Kaitai
{
    [TestFixture]
    public class SpecExprMod : CommonSpec
    {
        [Test]
        public void TestExprMod()
        {
            var r = ExprMod.FromFile(SourceFile("fixed_struct.bin"));
            Assert.AreEqual(r.IntU, 1262698832);
            Assert.AreEqual(r.IntS, -52947);
    
            Assert.AreEqual(r.ModPosConst, 9);
            Assert.AreEqual(r.ModNegConst, 4);
            Assert.AreEqual(r.ModPosSeq, 5);
            Assert.AreEqual(r.ModNegSeq, 2);
        }
    }
}
