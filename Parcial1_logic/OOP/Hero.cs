using System;

namespace Parcial1_logic.OOP
{
    public class Hero : Actor
    {
        public Hero(float atk, float def) : base(atk, def)
        {
        }

        public Weapon CurrentWeapon { get; protected set; }
        public Armor CurrentArmor { get; protected set; }

        public override float GetCurrentAtk
        {
            get
            {
                float weaponParamMod = CurrentWeapon == null ? 0F : CurrentWeapon.ParamMod;
                return BaseAtk * (1 + weaponParamMod);
            }
        }

        public override float GetCurrentDef
        {
            get
            {
                float armorParamMod = CurrentArmor == null ? 0F : CurrentArmor.ParamMod;
                return BaseDef * (1 + armorParamMod);
            }
        }

        public void ResetEquipment()
        {
            CurrentArmor = null;
            CurrentWeapon = null;
        }

        public override MovementType Move()
        {
            return MovementType.Input;
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public void Equip(Gear gear)
        {
            if (gear is Weapon)
            {
                CurrentWeapon = gear as Weapon;
            }
            else
            {
                CurrentArmor = gear as Armor;
            }
        }
    }
}