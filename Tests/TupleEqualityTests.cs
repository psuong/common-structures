using CommonStructures;
using NUnit.Framework;

namespace CommonStructures.Tests {
    
    public class TupleEqualityTests {

        private const string ValueMismatch = "Value Mismatch!";
        private const string NonValueMismatch = "Values are the same!";

        [Test]
        public void PairEqualityTest() {
            var zero = Tuple.Create(0, 0);
            Assert.AreEqual(zero, Tuple.Create(0, 0), ValueMismatch);
            Assert.AreNotEqual(zero, Tuple.Create(1, 1), NonValueMismatch);
        }

        [Test]
        public void TripleEqualityTest() {
            var one = Tuple.Create(1, 1, 1);
            Assert.AreEqual(one, Tuple.Create(1, 1, 1), ValueMismatch);
            Assert.AreNotEqual(one, Tuple.Create(0, 0, 1), NonValueMismatch);
        }

        [Test]
        public void FourTupleEqualityTest() {
            var fourTuple = Tuple.Create(1, 'c', 'a', 't');
            Assert.AreEqual(fourTuple, Tuple.Create(1, 'c', 'a', 't'), ValueMismatch);
            Assert.AreNotEqual(fourTuple, Tuple.Create(1, 'a', 'b', 'c'), NonValueMismatch);
        }

        [Test]
        public void FiveTupleEqualityTest() {
            var fiveTuple = Tuple.Create(1, 2, 3, "as", "cool");
            Assert.AreEqual(fiveTuple, Tuple.Create(1, 2, 3, "as", "cool"), ValueMismatch);
            Assert.AreNotEqual(fiveTuple, Tuple.Create(1, 2, 3, "AS", "COOL"), NonValueMismatch);
        }

        [Test]
        public void SixTupleEqualityTest() {
            var sixTuple = Tuple.Create(1, 2, 3, "tie", "your", "shoes");
            Assert.AreEqual(sixTuple, Tuple.Create(1, 2, 3, "tie", "your", "shoes"), NonValueMismatch);
        }

        [Test]
        public void SevenTupleEqualityTest() {
            var sevenTuple = Tuple.Create(1, 2, 3, 4, 5, 7.0, 6f);
            Assert.AreEqual(sevenTuple,  Tuple.Create(1, 2, 3, 4, 5, 7.0, 6f), ValueMismatch);
            Assert.AreNotSame(sevenTuple, Tuple.Create(1.0, 2, 3, 4, 5, 7.0, 6f), NonValueMismatch);
        }

        [Test]
        public void OctTupleEqualityTest() {
            var octTuple = Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8);
            Assert.AreEqual(octTuple, Tuple.Create(1, 2, 3, 4, 5, 6, 7, 8), ValueMismatch);
            Assert.AreNotEqual(octTuple, Tuple.Create('1', '2', '3', '4', '5', '6', '7', '8'), NonValueMismatch);
        }
    }
}
