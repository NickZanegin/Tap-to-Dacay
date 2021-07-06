using UnityEngine;

public class ProgressBar : MonoBehaviour
{
    public Transform[] XY;
    public GameObject Progress;
    public int[] LvlDay;
    float Point;
    int lvl = 0;
    int Clic=0;
    float SavePosistion;
    


    void Start()
    {
        Progress.transform.position = new Vector3(XY[0].position.x, XY[0].position.y, transform.position.z);
        if (PlayerPrefs.HasKey("SavePosistion"))
        {
            SavePosistion = PlayerPrefs.GetFloat("SavePosistion");
            Clic = PlayerPrefs.GetInt("Click");
            lvl = PlayerPrefs.GetInt("SaveLvl");
            Progress.transform.position = new Vector3(transform.position.x, transform.position.y + SavePosistion, transform.position.z);
        }
    }

     void Update()
    {
        if(Clic == LvlDay[lvl])
        {
            Clic = 0;
            lvl++;
            Progress.transform.position = new Vector3(XY[0].position.x, XY[0].position.y, transform.position.z);
        }
    }


    public void Move()
    {
        Clic++;
        Point = (float)(9.42 / LvlDay[lvl]);
        Progress.transform.position = new Vector3(transform.position.x, transform.position.y + Point, transform.position.z);
        SavePosistion = Point * Clic;
        PlayerPrefs.SetFloat("SavePos", SavePosistion);
        PlayerPrefs.SetInt("Click", Clic);
        PlayerPrefs.SetInt("SaveLvl", lvl);
    }
}
