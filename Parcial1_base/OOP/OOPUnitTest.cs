using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Parcial1_logic.OOP.Tests
{
    [TestClass()]
    public class OOPUnitTest
    {
        private readonly Hero testHero01 = new Hero(10, 5);

        private readonly Gear testWeapon01 = new Weapon(0.5F);
        private readonly Gear testWeapon02 = new Weapon(0.40F);
        private readonly Gear testArmor01 = new Armor(0.25F);

        private readonly NPC testNPC01 = new NPC();

        private readonly Enemy testEnemy01 = new Enemy(4, 2);

        private readonly KeyValuePair<float, float> testParams01 = new KeyValuePair<float, float>(4, 2);
        private readonly KeyValuePair<float, float> testParams02 = new KeyValuePair<float, float>(15, 6.25F);
        private readonly KeyValuePair<float, float> testParams03 = new KeyValuePair<float, float>(10, 5);

        private readonly OOPTest oopt = new OOPTest();

        [TestMethod()]
        public void MoveTest()
        {
            Assert.AreEqual(MovementType.AI, oopt.Move(testEnemy01));
            Assert.AreEqual(MovementType.Waypoint, oopt.Move(testNPC01));
            Assert.AreNotEqual(MovementType.AI, oopt.Move(testHero01));
        }

        [TestMethod()]
        public void EquipTest()
        {
            testHero01.ResetEquipment();

            testHero01.Equip(testWeapon01);
            Assert.AreEqual(true, oopt.IsWeaponEquipped(testHero01, testWeapon01 as Weapon));

            testHero01.Equip(testArmor01);
            Assert.AreEqual(true, oopt.IsArmorEquipped(testHero01, testArmor01 as Armor));

            Assert.AreEqual(false, oopt.IsWeaponEquipped(testHero01, testWeapon02 as Weapon));
        }

        [TestMethod()]
        public void GetActorParamsTest()
        {
            testHero01.ResetEquipment();

            Assert.AreEqual(testParams01, oopt.GetActorParams(testEnemy01));
            Assert.AreEqual(testParams03, oopt.GetActorParams(testHero01));

            testHero01.Equip(testWeapon01);
            testHero01.Equip(testArmor01);

            Assert.AreEqual(testParams02, oopt.GetActorParams(testHero01));
        }
    }
}