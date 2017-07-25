using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bogus;

namespace UnitTestsBogus
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            #region Arrange

            var persons = new Faker<UnitTestingWithBogusLibrary.Person>()
                .StrictMode(false)
                .CustomInstantiator(f => new UnitTestingWithBogusLibrary.Person())
                .Rules((f, o) =>
                {
                    o.Name = f.Name.FirstName();
                    o.Surname = f.Name.LastName();
                    o.Sex = f.PickRandom<UnitTestingWithBogusLibrary.Person.Gender>();
                });

            #endregion

            #region Act

            var person = persons.Generate(5);

            #endregion

            #region Assert

            foreach (var item in person)
            {
                Console.WriteLine($"{item.Name}, {item.Surname}, {item.Sex}, {item.Address}");
            }

            Assert.IsNotNull(person);

            #endregion

        }
    }
}
