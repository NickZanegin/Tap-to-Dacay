using UnityEngine;
using System;
using System.IO;

[Serializable]
public class Save : MonoBehaviour
{
    [NonSerialized] private string path;
    public int daySave = 0;
    public int dayValueSave = 0;
    public void SaveData(int day, int dayValue)
    {
#if UNITY_ANDROID && !UNITY_EDITOR
        path = Path.Combine(Application.pesistentDataPath, "Save.json");
#else
        path = Path.Combine(Application.dataPath, "Save.json");
#endif
        daySave = day;
        dayValueSave = dayValue;
        File.WriteAllText(path, JsonUtility.ToJson(this));
    }
}
