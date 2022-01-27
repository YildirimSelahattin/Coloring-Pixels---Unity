using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxClick : MonoBehaviour
{
    public SpriteRenderer solidbox;
    public void OnMouseDown()
    {
        solidbox.color = flow.selectedColor;
    }
}
