namespace BattleshipGame.Board
{
    public class DictionaryBoard : IBoard
    {
        #region IBoard Implementation
        AttackResult IBoard.AttackPosition(string attackRow, int attackColumn)
        {
            throw new System.NotImplementedException();
        }

        bool IBoard.IsGameOver()
        {
            throw new System.NotImplementedException();
        }

        void IBoard.PositionBattleship(int battleshipLength, string battleshipRow, int battleshipColumn, Orientation battleshipOrientation)
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}