using BattleshipGame.Location;

namespace BattleshipGame.Board
{
    /// <summary>
    /// Attack a position on the board
    /// </summary>
    internal class AttackPositionOnArrayBoard
    {
        public static AttackResult Attack(IArrayBoardObject board, Position attackLocation)
        {
            ILocation targetLocation = GetLocationOnArrayBoard.GetLocation(board, attackLocation);
            try
            {
                return targetLocation.Attack();
            }
            catch (LocationAlreadyAttackedException)
            {
                throw new PositionAlreadyAttackedException(string.Format("Position {0} has already been attacked previously.", targetLocation.GetPositionId()));
            }

        }
    }
}
