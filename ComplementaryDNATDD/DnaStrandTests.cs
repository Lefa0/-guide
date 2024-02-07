using ComplementaryDNA;

namespace ComplementaryDNATDD
{
    public class DnaStrandTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal("TTTT", DnaStrand.MakeComplement("AAAA"));
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal("AAAA", DnaStrand.MakeComplement("TTTT"));
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal("ATTGC", DnaStrand.MakeComplement("TAACG"));
        }

        [Fact]
        public void Test4()
        {
            Assert.Equal("GTAT", DnaStrand.MakeComplement("CATA"));
        }

        [Fact]
        public void Test5()
        {
            Assert.Equal("GTATCGATCGATCGATCGATTATATTTTCGACGAGATTTAAATATATATATATACGAGAGAATACAGATAGACAGATTA", DnaStrand.MakeComplement("CATAGCTAGCTAGCTAGCTAATATAAAAGCTGCTCTAAATTTATATATATATATGCTCTCTTATGTCTATCTGTCTAAT"));
        }
    }
}