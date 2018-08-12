namespace Parcial1_logic.OOP
{
    public abstract class Gear
    {
        public static float ParamModLimit = 0.99F;

        public float ParamMod { get; protected set; }

        public Gear(float paramMod)
        {
            ParamMod = paramMod.Clamp(0F, ParamModLimit);
        }
    }
}