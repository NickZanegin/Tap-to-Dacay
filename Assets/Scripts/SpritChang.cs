using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpritChang : MonoBehaviour
{
    public List<Sprite> sprite;
    public Image image;
    public void ChangeSprite()
    {
        sprite.RemoveAt(0);
        image.sprite = sprite[0];
    }
    public void LoadSprite(int index)
    {
        for (int i = 0; i < sprite.Count; i++)
        {
            if (i < index)
            {
                sprite.RemoveAt(0);
            }
            else
            {
                break;
            }
        }
        image.sprite = sprite[0];
    }
}
