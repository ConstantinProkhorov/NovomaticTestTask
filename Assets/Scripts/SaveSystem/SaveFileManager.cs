using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
/// <summary>
/// Saves and loads PlayerData type in file in binare format.
/// </summary>
public static class SaveFileManager
{
    private static string Path
    {
        get => Application.persistentDataPath + "player1.tsf";
    }
    /// <summary>
    /// Save PlayerData.
    /// </summary>
    /// <param name="data"></param>
    public static void Save(PlayerData data)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(Path, FileMode.Create);
        formatter.Serialize(stream, data);
        stream.Close();
    }
    /// <summary>
    /// Loads PlayerData.
    /// </summary>
    /// <returns></returns>
    public static PlayerData Load()
    {
        if (File.Exists(Path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(Path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            PlayerData data = FirstLoad();
            return data;
        }
    }
    private static PlayerData FirstLoad()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream stream = new FileStream(Path, FileMode.Create);
        PlayerData data = new PlayerData();
        formatter.Serialize(stream, data);
        stream.Close();
        return data;
    }
}

