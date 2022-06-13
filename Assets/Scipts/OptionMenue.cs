using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenue : MonoBehaviour
{
    bool menue = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (menue) Time.timeScale = 1;
            if (!menue) Time.timeScale = 0;
            menue = !menue;
        }
    }
}
