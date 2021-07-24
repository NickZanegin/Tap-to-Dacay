using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Text Day;
    public Text Name;

    public List<string> names;
    public void NextDay(int day)
    {
        Day.text = (day.ToString() + " Day");
    }
    public void NextName()
    {
        names.RemoveAt(0);
        Name.text = (names[0]);
    }
    public void LoadUI(int Index, int day)
    {
        for (int i = 0; i < names.Count; i++)
        {
            if (i < Index)
            {
                names.RemoveAt(0);
            }
            else
            {
                break;
            }
        }
        Name.text = (names[0]);
        Day.text = (day.ToString() + " Day");
    }
}
