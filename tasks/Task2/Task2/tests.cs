using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Task2
{
    [TestFixture]

    class tests
    {
        [Test]
        public void is_handgun()
        {
            Handgun h1 = new Handgun("Colt", 6.4m, 7);
            Assert.IsTrue(h1 is IWeapon);
        }

        [Test]
        public void is_handgun2()
        {
            Handgun h2 = new Handgun(24, 7.25m);
            Assert.IsTrue(h2 is IWeapon);
        }

        [Test]
        public void is_handgun3()
        {
            Handgun h3 = new Handgun("M16", 8.55m);
            Assert.IsTrue(h3 is IWeapon);
        }

        [Test]
        public void silencer_test()
        {
            Handgun h4 = new Handgun("M16", 8.55m);
            h4.silencer = "true";
            Assert.IsTrue(h4.silencer == "true");       
        }
        [Test]
        public void type_test()
        {
            Handgun h4 = new Handgun("M16", 8.55m);
            h4.type = "Handgun";
            Assert.IsTrue(h4.type == "Handgun");
        }

        [Test]
        public void caliber_test()
        {
            Handgun h4 = new Handgun("M16", 8.55m);
            Console.WriteLine($"Caliber: {h4.Caliber}");
            Assert.AreEqual(h4.Caliber, 8.55m);
        }

        [Test]
        public void name_test()
        {
            Handgun h4 = new Handgun("M16", 8.55m);
            Console.WriteLine($"Caliber: {h4.Name}");
            Assert.AreEqual(h4.Name, "M16");
        }
        [Test]
        public void clipsize_test()
        {
            Handgun h4 = new Handgun(25, 8.55m);
            Console.WriteLine($"Clipsize updated to {h4.UpdateClipsize(30)}");
            Assert.AreEqual(h4.UpdateClipsize(30), 30);
        }
    }

}
