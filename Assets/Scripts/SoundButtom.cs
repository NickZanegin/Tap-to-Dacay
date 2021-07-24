using UnityEngine.UI;
using UnityEngine;

public class SoundButtom : MonoBehaviour
{
    public AudioSource SoundMenager;
    Image Button;
    public Sprite On;
    public Sprite Off;
    private void Start()
    {
        Button = GetComponent<Image>();
    }
    public void ClickButton()
    {
        if (SoundMenager.mute == false)
        {
            SoundMenager.mute = true;
            Button.sprite = On;
        }
        else
        {
            SoundMenager.mute = false;
            Button.sprite = Off;
        }
    }
}
