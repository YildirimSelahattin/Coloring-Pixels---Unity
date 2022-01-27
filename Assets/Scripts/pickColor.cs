using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickColor : MonoBehaviour
{
    public void OnMouseDown()
    {
        flow.selectedColor = GetComponent<Image>().color;
        flow.selectedTag = gameObject.tag;
        Debug.Log(flow.selectedTag);
    }

}
