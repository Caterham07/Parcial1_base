namespace Parcial1_logic.OOP
{
    public abstract class Actor : ICharacter
    {
        private float baseAtk;
        private float baseDef;

        public abstract float GetCurrentAtk { get; }
        public abstract float GetCurrentDef { get; }

        public virtual float BaseAtk
        {
            get
            {
                return baseAtk;
            }

            protected set
            {
                baseAtk = value;
            }
        }

        public virtual float BaseDef
        {
            get
            {
                return baseDef;
            }

            protected set
            {
                baseDef = value;
            }
        }

        public Actor(float atk, float def)
        {
            BaseAtk = atk;
            BaseDef = def;
        }

        public abstract MovementType Move();

        public abstract void Attack();
    }
}