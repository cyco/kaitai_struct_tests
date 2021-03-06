using System;

namespace Kaitai
{
    using NUnit.Framework;

    [TestFixture]
    public class SpecFixedStruct : CommonSpec
    {
        [Test]
        public void TestFixedStruct()
        {
            var r = FixedStruct.FromFile(SourceFile("fixed_struct.bin"));

            Assert.AreEqual(r.Hdr.Uint8, 255);
            Assert.AreEqual(r.Hdr.Uint16, 65535);
            Assert.AreEqual(r.Hdr.Uint32, 4294967295L);
            Assert.AreEqual(r.Hdr.Uint64, 18446744073709551615);
            Assert.AreEqual(r.Hdr.Uint64, 0xFFFFFFFFFFFFFFFF);

            Assert.AreEqual(r.Hdr.Sint8, -1);
            Assert.AreEqual(r.Hdr.Sint16, -1);
            Assert.AreEqual(r.Hdr.Sint32, -1);
            Assert.AreEqual(r.Hdr.Sint64, -1);

            Assert.AreEqual(r.Hdr.Uint16le, 66);
            Assert.AreEqual(r.Hdr.Uint32le, 66);
            Assert.AreEqual(r.Hdr.Uint64le, 66);

            Assert.AreEqual(r.Hdr.Sint16le, -66);
            Assert.AreEqual(r.Hdr.Sint32le, -66);
            Assert.AreEqual(r.Hdr.Sint64le, -66);

            Assert.AreEqual(r.Hdr.Uint16be, 66);
            Assert.AreEqual(r.Hdr.Uint32be, 66);
            Assert.AreEqual(r.Hdr.Uint64be, 66);

            Assert.AreEqual(r.Hdr.Sint16be, -66);
            Assert.AreEqual(r.Hdr.Sint32be, -66);
            Assert.AreEqual(r.Hdr.Sint64be, -66);
        }
    }
}
