using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxClick : MonoBehaviour
{
    public SpriteRenderer solidbox;
    public void OnMouseDown()
    {
        if (gameObject.tag == flow.selectedTag)
        {
            solidbox.color = flow.selectedColor;
        }
    }
}
