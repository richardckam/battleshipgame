namespace BattleshipGame
{
    #region Public Enums
    /// <summary>
    /// Orientation of a ship on a board
    /// </summary>
    public enum Orientation
    {
        Horizontal, 
        Vertical,
    }
    /// <summary>
    /// Result of attack on a Location
    /// </summary>
    public enum AttackResult
    {
        Hit,
        Miss,
    }
    #endregion

    #region Internal Enums
    /// <summary>
    /// Status of attack for a location
    /// </summary>
    internal enum AttackStatus
    {
        Hit,
        Miss,
        NotAttacked,
    }
    #endregion
}