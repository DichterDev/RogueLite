using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    PlayerManager playerManager;

    GameObject[] hearts;
    // Start is called before the first frame update
    void Start()
    {
        playerManager = GetComponent<PlayerManager>();
        hearts = GameObject.FindGameObjectsWithTag("Heart");
    }

    // Update is called once per frame
    void Update()
    {
        if (playerManager.CurrentHP == 3)
        {
            hearts[0].GetComponent<Image>().sprite = playerManager.heart_full;
            hearts[1].GetComponent<Image>().sprite = playerManager.heart_full;
            hearts[2].GetComponent<Image>().sprite = playerManager.heart_full;
        }
        if (playerManager.CurrentHP == 2)
        {
            hearts[0].GetComponent<Image>().sprite = playerManager.heart_full;
            hearts[1].GetComponent<Image>().sprite = playerManager.heart_full;
            hearts[2].GetComponent<Image>().sprite = playerManager.heart_empty;
        }
        if (playerManager.CurrentHP == 1)
        {
            hearts[0].GetComponent<Image>().sprite = playerManager.heart_full;
            hearts[1].GetComponent<Image>().sprite = playerManager.heart_empty;
            hearts[2].GetComponent<Image>().sprite = playerManager.heart_empty;
        }        
        if (playerManager.CurrentHP == 0)
        {
            hearts[0].GetComponent<Image>().sprite = playerManager.heart_empty;
            hearts[1].GetComponent<Image>().sprite = playerManager.heart_empty;
            hearts[2].GetComponent<Image>().sprite = playerManager.heart_empty;
        }
    }
}
