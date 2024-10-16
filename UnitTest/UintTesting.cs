using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;

namespace UnitTest
{
    [TestFixture]
    public class UintTesting
    {
        private readonly string[] daylist = { "Senin", "Selasa", "Rabu", "Kamis", "Jum'at", "Sabtu", "Minggu" };
        private Day day;
        private User user;
        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();
        }
        [Test]
        public void DayValidator()
        {
            for (int numberOfDay = 0; numberOfDay < daylist.Length; numberOfDay++)
            {
                //atur agar index 0 di dayList sesuai dengan NumberTest tester di method nameOfDay

                Assert.AreEqual(daylist[numberOfDay], day.NameOfDay(numberOfDay +1));
                
            }
        }
        [Test]
        public void UserValidator()
        {
               //cek apakah userInput yang benar bisa di terima
            Assert.IsTrue(user.IsValidUser("admin","admin"));
                //jika userInput tidak sama
            Assert.IsFalse(user.IsValidUser("admin", "admin123"));
        }
        
    }
}
