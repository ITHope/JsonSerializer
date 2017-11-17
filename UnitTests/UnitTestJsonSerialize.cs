using NUnit.Framework;
using System;
using System.Collections.Generic;
using JsonSerializer;
using Newtonsoft.Json;

namespace UnitTests
{
    [TestFixture]
    public class UnitTestJsonSerialize
    {
        public static object[] _sourceLists = {new object[] {new List<Person> { null }},  //case 0
                                     new object[] { new List<Person> { new Person(1, "Sam", "Smith", 60) } }, //case 1
                                     new object[] { new List<Person> { new Person(1, "Sam", "Smith", 60), new Person(2, "John", "Doe", 30) } } //case 2
                                    };

        [Test, TestCaseSource("_sourceLists")]
        public void PersonsJsonSerializerTest(object[] list)
        {
            List<Object> listTest = new List<Object>();

            string res = Program.listToJson(listTest);
            string exp = JsonConvert.SerializeObject(listTest);
            Assert.AreEqual(exp, res);
        }

        [Test]
        public void PersonsJsonSerLibTest0()
        {
            List<Object> listTest = new List<Object>();
            string res = Program.listToJson(listTest);
            string exp = "[]";
            Assert.AreEqual(exp, res);
        }
        [Test]
        public void PersonsJsonSerLibTest1()
        {
            List<Object> listTest = new List<Object>();
            listTest.Add(new Person(1, "Sam", "Smith", 60));
            string res = Program.listToJson(listTest);
            string exp = "[{\"Id\":1,\"FirstName\":\"Sam\",\"LastName\":\"Smith\",\"Age\":60}]";
            Assert.AreEqual(exp, res);
        }
        [Test]
        public void PersonsJsonSerLibTest2()
        {
            List<Object> listTest = new List<Object>();
            listTest.Add(new Person(1, "Sam", "Smith", 60));
            listTest.Add(new Person(2, "John", "Doe", 30));
            string res = Program.listToJson(listTest);
            string exp = "[{\"Id\":1,\"FirstName\":\"Sam\",\"LastName\":\"Smith\",\"Age\":60}," +
                          "{\"Id\":2,\"FirstName\":\"John\",\"LastName\":\"Doe\",\"Age\":30}]";
            Assert.AreEqual(exp, res);
        }

        [Test]
        public void PersonsJsonSerStrTest0()
        {
            List<Object> listTest = new List<Object>();
            string res = Program.listToJson(listTest);
            string exp = JsonConvert.SerializeObject(listTest);
            Assert.AreEqual(exp, res);
        }
        [Test]
        public void PersonsJsonSerStrTest1()
        {
            List<Object> listTest = new List<Object>();
            listTest.Add(new Person(1, "Sam", "Smith", 60));
            string res = Program.listToJson(listTest);
            string exp = JsonConvert.SerializeObject(listTest);
            Assert.AreEqual(exp, res);
        }
        [Test]
        public void PersonsJsonSerStrTest2()
        {
            List<Object> listTest = new List<Object>();
            listTest.Add(new Person(1, "Sam", "Smith", 60));
            listTest.Add(new Person(2, "John", "Doe", 30));
            string res = Program.listToJson(listTest);
            string exp = JsonConvert.SerializeObject(listTest);
            Assert.AreEqual(exp, res);
        }
    }
}
