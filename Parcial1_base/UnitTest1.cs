using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Parcial1_logic.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        private TestObject to = new TestObject();

        #region COLLECTIONS

        private readonly Queue<int> testQueue01 = new Queue<int>(new[] { 5, 4, 2, 6, 10 });
        private readonly Queue<int> testQueue02 = new Queue<int>(new[] { 10, 200, 5, 9, 10, 96547 });
        private readonly Queue<int> testQueue03 = new Queue<int>(new[] { 99, 4000, 584, 68, 104, 584, 462, 120 });

        private readonly Queue<string> testQueue04 = new Queue<string>(new[] { "hola", "mundo", "examen", "upb", "scripting" });
        private readonly Queue<string> testQueue05 = new Queue<string>(new[] { "mañana", "apex", "songoku", });
        private readonly Queue<string> testQueue06 = new Queue<string>(new[] { "adios", "mundo", "cruel", "monikadabest", "youaremysunshine", "myonlysunshine" });

        private readonly Queue<char> testQueue07 = new Queue<char>(new[] { 'a', 'A', 'd', '*', '\n' });

        private readonly Queue<int> replacedQueue01 = new Queue<int>(new[] { 5, 4, 2, 5, 10 });
        private readonly Queue<int> replacedQueue02 = new Queue<int>(new[] { 5, 200, 5, 9, 5, 96547 });
        private readonly Queue<int> replacedQueue03 = new Queue<int>(new[] { 99, 4000, 0, 68, 104, 0, 462, 120 });

        private readonly Stack<string> testStack01 = new Stack<string>(new[] { "hola", "generico", "perder", "sophia", "nocancelenpofavo", "seikendensetsu" });
        private readonly Stack<string> testStack02 = new Stack<string>(new[] { "simpson", "cosme", "peranito" });
        private readonly Stack<string> testStack03 = new Stack<string>(new[] { "sesuponequeestonofunciona" });

        private readonly Stack<string> invertedStack01 = new Stack<string>(new[] { "sesuponequeestonofunciona" });
        private readonly Stack<string> invertedStack02 = new Stack<string>(new[] { "seikendensetsu", "nocancelenpofavo", "sophia", "perder", "generico", "hola" });
        private readonly Stack<string> invertedStack03 = new Stack<string>(new[] { "fulanito", "cosme", "simpson" });

        private readonly List<string> mixedList01 = new List<string>() { "seikendensetsu", "hola", "nocancelenpofavo", "mundo", "sophia", "examen", "perder", "upb", "generico", "scripting" };
        private readonly List<string> mixedList02 = new List<string>() { "sesuponequeestonofunciona", "mañana" };
        private readonly List<string> mixedList03 = new List<string>() { "peranito", "5", "cosme", "4", "simpson", "2" };

        private readonly Dictionary<int, string> testDict01 = new Dictionary<int, string>()
        {
            { 0, "helloworld"},
            { 1, "holamundo"},
            { 2, "anitalavalatina"},
            { 3, "murcielago"},
            { 4, "sihayunexamenganableeseste"}
        };

        private readonly Dictionary<int, char> testDict02 = new Dictionary<int, char>()
        {
            { 0, 'h'},
            { 1, 'a'},
            { 2, 'b'},
            { 3, '/'},
            { 4, '_'},
        };

        private readonly Dictionary<int, bool> testDict03 = new Dictionary<int, bool>()
        {
            { 0, false },
            { 1, true },
            { 2, true },
            { 3, true },
            { 4, false}
        };

        #endregion COLLECTIONS

        #region DATA_STRUCTURES

        [TestMethod()]
        public void ReplaceIntestQueue()
        {
            CollectionAssert.AreEqual(replacedQueue01, to.ReplaceInQueue(testQueue01, 6, 5));
            CollectionAssert.AreNotEqual(replacedQueue02, to.ReplaceInQueue(testQueue02, 6, 10));
            CollectionAssert.AreEqual(replacedQueue03, to.ReplaceInQueue(testQueue03, 584, 0));
        }

        [TestMethod()]
        public void InverseStackTest()
        {
            CollectionAssert.AreEqual(invertedStack02, to.InverseStack(testStack01));
            CollectionAssert.AreNotEqual(invertedStack03, to.InverseStack(testStack02));
            CollectionAssert.AreEqual(invertedStack01, to.InverseStack(testStack03));
        }

        [TestMethod()]
        public void MixDataTest()
        {
            CollectionAssert.AreEqual(mixedList01, to.MixData(testStack01, testQueue04));
            CollectionAssert.AreEqual(mixedList02, to.MixData(testStack03, testQueue05));
            CollectionAssert.AreEqual(mixedList03, to.MixData(testStack02, testQueue01.ToQueueOfString()));
        }

        [TestMethod()]
        public void RepeatedTimesInDictionaryTest()
        {
            Assert.AreEqual(0, to.RepeatedTimesInDictionary(testDict01, "pedrojuan"));
            Assert.AreEqual(1, to.RepeatedTimesInDictionary(testDict02, '_'));
            Assert.AreEqual(3, to.RepeatedTimesInDictionary(testDict03, true));
        }

        #endregion DATA_STRUCTURES

        #region BONUS

        //

        #endregion BONUS
    }
}