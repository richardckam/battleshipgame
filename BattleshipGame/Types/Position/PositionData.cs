using System.Text;

namespace BattleshipGame
{
    internal class PositionData
    {
        #region Private Readonly Variables
        private static readonly int _asciiBaseRowIndex = (int)ASCIIEncoding.ASCII.GetBytes("A")[0];
        #endregion 
        public static int AsciiBaseRowIndex { get { return _asciiBaseRowIndex; } }
    }
}
