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
            flow.wrong = 97;
        }

    }
    public void OnMouseDown()
    {

        solidbox.color = flow.selectedColor;
        flow.selectedColor.a = 1f;
        if (gameObject.tag == flow.selectedTag)
        {
            flow.wrong -= 1;
            Debug.Log(flow.wrong);
            
            solidbox.color = flow.selectedColor;
        }
        flow.selectedColor.a = 0.70f;
        if (gameObject.tag != flow.selectedTag)
        {
            flow.selectedColor.a = 0.70f;
        }

        if(flow.selectedTag == ("erase") )
        {
            flow.selectedColor.a = 0f;
            flow.wrong += 1;
        }
    }
}
