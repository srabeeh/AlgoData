using NUnit.Framework;
using LinkedList;

namespace LinkedListTests.SingleList
{
    [TestFixture]
    public class Clear
    {
        [Test]
        public void Clear_Empty()
        {
            LinkedList<int> list = new LinkedList<int>();

            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
            Assert.AreEqual(0, list.Count);

            list.Clear();

            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
            Assert.AreEqual(0, list.Count);
        }

        [Test, TestCaseSource("_testCases")]
        public void Clear_VariousItems(int[] testCase)
        {
            LinkedList<int> list = new LinkedList<int>();
            foreach (int value in testCase)
            {
                list.AddLast(new LinkedListNode<int>(value));
            }

            Assert.IsNotNull(list.Head);
            Assert.IsNotNull(list.Tail);
            Assert.AreEqual(testCase.Length, list.Count);

            list.Clear();

            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);
            Assert.AreEqual(0, list.Count);
        }

        static object[] _testCases =
                     {
                            new int[] { 0 }, 
                            new int[] { 0, 1 }, 
                            new int[] { 0, 1, 2 }, 
                            new int[] { 0, 1, 2, 3 }, 
                     };


    }
}
