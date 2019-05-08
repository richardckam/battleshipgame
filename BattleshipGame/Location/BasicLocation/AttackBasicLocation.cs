namespace BattleshipGame.Location
{
    /// <summary>
    /// Attack a Basic Location
    /// </summary>
    internal class AttackBasicLocation
    {
        internal static AttackResult Attack(IBasicLocationObject location)
        {
            if (location.Status != AttackStatus.NotAttacked)
            {
                throw new LocationAlreadyAttackedException(string.Format("Location {0} has already been attacked.", location.PositionId));
            }

            if (location.IsOccupied)
            {
                location.Status = AttackStatus.Hit;
                return AttackResult.Hit;
            }
            else
            {
                location.Status = AttackStatus.Miss;
                return AttackResult.Miss;
            }
        }
    }
}
