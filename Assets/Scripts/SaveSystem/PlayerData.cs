/// <summary>
/// Serializable class for player data to be saved using SaveFileManager.
/// </summary>
[System.Serializable]
public class PlayerData
{
    public int BallsTotalNumber;
    public PlayerData()
    {
        BallsTotalNumber = 0;
    }
    public PlayerData(PlayerData currentState)
    {
        BallsTotalNumber = currentState.BallsTotalNumber;
    }
}
