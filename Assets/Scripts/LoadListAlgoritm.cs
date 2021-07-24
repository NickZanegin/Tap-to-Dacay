using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadListAlgoritm<T> : MonoBehaviour
{
    public List<T> RemovingExcess(List<T> list,int index)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (i < index)
            {
                list.RemoveAt(0);
            }
            else
            {
                break;
            }
        }
        return list;
    }
}
