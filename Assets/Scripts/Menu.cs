using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource ButtonSound;
    public void OpenScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Sound()
    {
        ButtonSound.Play();
    }
}
