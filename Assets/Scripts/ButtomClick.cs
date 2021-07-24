using System.Collections.Generic;
using UnityEngine;

public class ButtomClick : MonoBehaviour
{
    public SpritChang sprit;
    public UI uI;
    public Sound sound;
    public AnimationClick anim;
    public int day;
    public int dayValue;
    public List<int> nextTrah;
    private void Awake()
    {
        Load load = new Load();
        day = load.LoadDay();
        dayValue = load.LoadDayValue();
    }
    void Start()
    {
        if(day > 0)
        {
            int index = 0;
            for (int i = 0; i < nextTrah.Count; i++)
            {
                if (dayValue < nextTrah[i])
                {
                    index = i;
                    break;
                }
            }
            LoadListAlgoritm<int> loadList = new LoadListAlgoritm<int>();
            nextTrah = loadList.RemovingExcess(nextTrah, index);
            sprit.LoadSprite(index);
            uI.LoadUI(index, day);
        }
    }
    public void Click()
    {
        day++;
        dayValue++;
        if (nextTrah[0] == day)
        {
            nextTrah.RemoveAt(0);
            uI.NextName();
            sprit.ChangeSprite();
            day = 0;
        }
        anim.StartAnimation();
        sound.Play();
        uI.NextDay(day);
        if(day == 365001)
        {
            FinalUI final = new FinalUI();
            final.Thanks();
        }
    }
    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            Save save = new Save();
            save.SaveData(day, dayValue);
        }
    }
    private void OnApplicationQuit()
    {
        Save save = new Save();
        save.SaveData(day, dayValue);
    }
}
