using CommonStructures;
using NUnit.Framework;

namespace CommonStructures.Tests {

    /// <summary>
    /// A simple test file to ensure that the tuples just store data and don't manipulate it.
    /// </summary>
    public class TupleTests {

        [Test]
        public void TestDouble() {
            var @double = Tuple.CreateTuple(0, 1);
            Assert.AreEqual(0, @double.item1, "Ordered double mismatch");
            Assert.AreEqual(1, @double.item2, "Ordered double mismatch");
        }

        [Test]
        public void TestTriples() {
            var triple = Tuple.CreateTuple(0, "A String", 'c');
            Assert.AreEqual(0, triple.item1, "Value mismatch!");
            Assert.AreEqual("A String", triple.item2, "Value mismatch!");
        }

        [Test]
        public void TestFourTuples() {
            var fourTuple = Tuple.CreateTuple(0f, 1f, 2f, 3f);
            Assert.AreEqual(0f, fourTuple.item1, "Value mismatch!");
            Assert.AreEqual(1f, fourTuple.item2, "Value mismatch!");
            Assert.AreEqual(2f, fourTuple.item3, "Value mismatch!");
            Assert.AreEqual(3f, fourTuple.item4, "Value mismatch!");
        }

        [Test]
        public void TestFiveTuples() {
            var fiveTuple = Tuple.CreateTuple('a', 'b', 'c', 'd', 'e');
            Assert.AreEqual('a', fiveTuple.item1, "Value mismatch!");
            Assert.AreEqual('b', fiveTuple.item2, "Value mismatch!");
            Assert.AreEqual('c', fiveTuple.item3, "Value mismatch!");
            Assert.AreEqual('d', fiveTuple.item4, "Value mismatch!");
            Assert.AreEqual('e', fiveTuple.item5, "Value mismatch!");
        }

        [Test]
        public void TestSexTuple() {
            var sexTuple = Tuple.CreateTuple('a', "lot of different values", 1, 2f, 3.0, true);
            Assert.AreEqual('a', sexTuple.item1, "Value mismatch!");
            Assert.AreEqual("lot of different values", sexTuple.item2, "Value mismatch!");
            Assert.AreEqual(1, sexTuple.item3, "Value mismatch!");
            Assert.AreEqual(2f, sexTuple.item4, "Value mismatch!");
            Assert.AreEqual(3.0 , sexTuple.item5, "Value mismatch!"); 
            Assert.True(sexTuple.item6, "Somehow a true turned into a false!");
        }

        [Test]
        public void TestSepTuple() {
            var sepTuple = Tuple.CreateTuple(1, 2, 3, 4, 5, 6, 7);
            Assert.AreEqual(1, sepTuple.item1, "Value mismatch!");
            Assert.AreEqual(2, sepTuple.item2, "Value mismatch!");
            Assert.AreEqual(3, sepTuple.item3, "Value mismatch!");
            Assert.AreEqual(4, sepTuple.item4, "Value mismatch!");
            Assert.AreEqual(5, sepTuple.item5, "Value mismatch!");
            Assert.AreEqual(6, sepTuple.item6, "Value mismatch!");
            Assert.AreEqual(7, sepTuple.item7, "Value mismatch!");
        }

        [Test]
        public void TestOctTuple() {
            var octTuple = Tuple.CreateTuple(1f, 2.0f, 3f, 4f, 5f, 6f, 7f, 8f);
            Assert.AreEqual(1f, octTuple.item1, "Value mismatch!");
            Assert.AreEqual(2.0f, octTuple.item2, "Value mismatch!");
            Assert.AreEqual(3f, octTuple.item3, "Value mismatch!");
            Assert.AreEqual(4f, octTuple.item4, "Value mismatch!");
            Assert.AreEqual(5f, octTuple.item5, "Value mismatch!");
            Assert.AreEqual(6f, octTuple.item6, "Value mismatch!");
            Assert.AreEqual(7f, octTuple.item7, "Value mismatch!");
            Assert.AreEqual(8f, octTuple.item8, "Value mismatch!");
        }
    }
}
