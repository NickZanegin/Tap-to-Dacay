using UnityEngine;

public class AnimationClick : MonoBehaviour
{
    public Animation anim;
    public void StartAnimation()
    {
        anim.Play("Click");
    }
}
