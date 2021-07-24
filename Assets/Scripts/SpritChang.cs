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
        LoadListAlgoritm<Sprite> loadList = new LoadListAlgoritm<Sprite>();
        sprite = loadList.RemovingExcess(sprite, index);
        image.sprite = sprite[0];
    }
}
