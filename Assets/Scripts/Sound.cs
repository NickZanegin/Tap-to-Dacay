using UnityEngine.UI;
using UnityEngine;

public class Sound : MonoBehaviour
{
    [SerializeField]
    GameObject SoundMenager;
    [SerializeField]
    GameObject Button;
    [SerializeField]
    Sprite[] Sprite;

    public void ClickButton()
    {
        if (SoundMenager.GetComponent<AudioSource>().mute == false)
        {
            SoundMenager.GetComponent<AudioSource>().mute = true;
            Button.GetComponent<Image>().sprite = Sprite[0];
        }
        else
        {
            SoundMenager.GetComponent<AudioSource>().mute = false;
            Button.GetComponent<Image>().sprite = Sprite[1];
        }

    }
}
