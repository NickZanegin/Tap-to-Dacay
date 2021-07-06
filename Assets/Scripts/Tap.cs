using UnityEngine;
using UnityEngine.UI;

public class Tap : MonoBehaviour
{
    [HideInInspector]
    public int day;
    int DayUi;//Счет дней, выводимый на экран (для каждого кейса считается с нуля).
    [HideInInspector]
    public bool button = false;
    public Text Day;
    public Text Name;
    public Sprite[] obj;
    public string[] nameUI;
    public Image Final;
    int IndexImage;
    int IndexName;

    void Awake()
    {
        if (PlayerPrefs.HasKey("Day"))
        {
            day = PlayerPrefs.GetInt("Day");
            IndexImage = PlayerPrefs.GetInt("Index");
            DayUi = PlayerPrefs.GetInt("UI");
            Name.text = PlayerPrefs.GetString("Name");
        }
        if (day >= 31)
        {
            GetComponent<Image>().sprite = obj[IndexImage];
        }
    }

    void Update()
    {
    //Заменяет ассет объекта, тем самым запуская новый уровень.
       switch (day)
        {
            case 31:
                IndexImage = 0;
                IndexName = 0;
                NextLvl();
                break;
            case 92:
                IndexImage = 1;
                IndexName = 1;
                NextLvl();
                break;
            case 183:
                IndexImage = 2;
                IndexName = 2;
                NextLvl();
                break;
            case 274:
                IndexImage = 3;
                IndexName = 3;
                NextLvl();
                break;
            case 455:
                IndexImage = 4;
                IndexName = 4;
                NextLvl();
                break;
            case 821:
                IndexImage = 5;
                IndexName = 5;
                NextLvl();
                break;
            case 1369:
                IndexImage = 6;
                IndexName = 6;
                NextLvl();
                break;
            case 3195:
                IndexImage = 7;
                IndexName = 7;
                NextLvl();
                break;
            case 6846:
                IndexImage = 8;
                IndexName = 8;
                NextLvl();
                break;
            case 21447:
                IndexImage = 9;
                IndexName = 9;
                NextLvl();
                break;
            case 57948:
                IndexImage = 10;
                IndexName = 10;
                NextLvl();
                break;
            case 94449:
                IndexImage = 11;
                IndexName = 11;
                NextLvl();
                break;
            case 276950:
                IndexImage = 12;
                IndexName = 12;
                NextLvl();
                break;
            case 532451:
                IndexImage = 13;
                IndexName = 13;
                NextLvl();
                break;
            case 897452:
                gameObject.SetActive(false);
                Final.gameObject.SetActive(true);
                break;
        }
        Day.text = (DayUi.ToString() + " Day");
    }

    void NextLvl()
    {
        GetComponent<Image>().sprite = obj[IndexImage];
        Name.text = nameUI[IndexName];
        DayUi = 0;
    }

    //Вызывается через компонент Event Trigger и срабатывает при клике на скрытую кнопку.
    public void OnClick()
    {
        DayUi++;
        day++;
        GetComponent<Animation>().Play("Click");
        PlayerPrefs.SetInt("Day", day);
        PlayerPrefs.SetInt("Index", IndexImage);
        PlayerPrefs.SetInt("UI", DayUi);
        PlayerPrefs.SetString("Name", Name.text);
    }
    // Метод вызывается триггером в последнем кадре анимации. Нужно, что бы при большом колличестве кликов анимация не заканчивалась на приозвольном кадре.
    private void StopAnim()
    {
        GetComponent<Animation>().Stop("Click");
    }
}
