using System.IO;
using UnityEngine;

public class Load : MonoBehaviour
{
    private string path;
    public int LoadDay()
    {
        Save Save = new Save();
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.pesistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif
        if (File.Exists(path))
        {
            JsonUtility.FromJsonOverwrite(File.ReadAllText(path), Save);
        }
        return Save.daySave;
    }
    public int LoadDayValue()
    {
        Save Save = new Save(); ;
        if (File.Exists(path))
        {
            JsonUtility.FromJsonOverwrite(File.ReadAllText(path), Save);
        }
        return Save.dayValueSave;
    }
}