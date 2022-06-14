using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionMenue : MonoBehaviour
{
    bool menue = false;
    public Canvas canvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (menue)
            {
                Time.timeScale = 1;
                canvas.enabled = false;
            }
            if (!menue)
            {
                Time.timeScale = 0;
                canvas.enabled = true;
            }
            menue = !menue;
        }
    }
}
