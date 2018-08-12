namespace Parcial1_logic.OOP
{
    public class NPC : ICharacter
    {
        public MovementType Move()
        {
            return MovementType.Waypoint;
        }
    }
}