using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boxClick : MonoBehaviour
{
    public SpriteRenderer solidbox;

    private void Update()
    {
        if(flow.wrong < 1)
        {
            SceneManager.LoadScene("gameStart");
            flow.wrong = 11;
        }
    }
    public void OnMouseDown()
    {

        solidbox.color = flow.selectedColor;

        if (gameObject.tag == flow.selectedTag)
        {
            flow.wrong -= 1;
            Debug.Log(flow.wrong);
        }
    }
}
