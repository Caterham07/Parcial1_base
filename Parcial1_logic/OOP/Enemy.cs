using System;

namespace Parcial1_logic.OOP
{
    public class Enemy : Actor
    {
        public Enemy(float atk, float def) : base(atk, def)
        {
        }

        public override float GetCurrentAtk
        {
            get
            {
                return BaseAtk;
            }
        }

        public override float GetCurrentDef
        {
            get
            {
                return BaseDef;
            }
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override MovementType Move()
        {
            return MovementType.AI;
        }
    }
}