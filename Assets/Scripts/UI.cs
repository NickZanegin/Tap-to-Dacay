using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Image Final;
    public Image ThankYou;
    public AudioSource ButtonSound;
    public void Thanks()
    {
        Final.gameObject.SetActive(false);
        ThankYou.gameObject.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Sound()
    {
        ButtonSound.pitch = Random.Range(0.75f, 1.25f);
        ButtonSound.Play();
    }


}
