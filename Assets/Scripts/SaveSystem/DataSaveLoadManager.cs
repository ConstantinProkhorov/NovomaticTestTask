using UnityEngine;
/// <summary>
/// Manages saving PlayerData when user quits application, and loading it when application is loaded.
/// </summary>
public class DataSaveLoadManager
{
    private static PlayerData PlayerData;
    [RuntimeInitializeOnLoadMethod]
    private static void OnStart()
    {
        //Я бы в норме так не стал делать, я бы написал коллекцию, куда все scriptableObjects регистрируют себя и уже оттуда бы брал значение, 
        //но было сказано не делать лишнего, поэтому я и не стал так делать. 
        IntegerValue[] integerValue = Resources.FindObjectsOfTypeAll<IntegerValue>();
        PlayerData = SaveFileManager.Load();
        integerValue[0].Value = PlayerData.BallsTotalNumber;
        Application.quitting += () =>
        {
            PlayerData.BallsTotalNumber = integerValue[0];
            SaveFileManager.Save(PlayerData);
        };
    }
}
