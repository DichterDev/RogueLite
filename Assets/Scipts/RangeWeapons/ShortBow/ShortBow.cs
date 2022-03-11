using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShortBow : MonoBehaviour
{
    public float MaxDrawTime = 5f;
    public float MinDrawTime = 1f;
    public float movementDecrease = 0f;
    public float arrowTravelTime = 2f;

    private Player player;

    private void Awake()
    {
        player = FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "ShortBow";
    }

    // Update is called once per frame
    void Update()
    {
        if (player.equippedWeapon == gameObject)
        {

        }
    }
}
