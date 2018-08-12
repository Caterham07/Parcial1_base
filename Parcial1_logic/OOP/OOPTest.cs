using System;
using System.Collections.Generic;

namespace Parcial1_logic.OOP
{
    public class OOPTest
    {
        public MovementType Move(ICharacter character)
        {
            return character.Move();
        }

        public bool IsWeaponEquipped(Hero hero, Weapon weapon)
        {
            return hero.CurrentWeapon.Equals(weapon);
        }

        public bool IsArmorEquipped(Hero hero, Armor armor)
        {
            return hero.CurrentArmor.Equals(armor);
        }

        public KeyValuePair<float, float> GetActorParams(Actor actor)
        {
            KeyValuePair<float, float> actorParams = new KeyValuePair<float, float>(actor.GetCurrentAtk, actor.GetCurrentDef);

            return actorParams;
        }
    }
}