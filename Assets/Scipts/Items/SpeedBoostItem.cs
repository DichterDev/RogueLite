using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    public int SpeedBoost = 5;
    private Player player;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider == null)
        {
            return;
        }
        else if (collision.gameObject.name == "Player")
        {
            player = collision.gameObject.GetComponent<Player>();
            player.Velocity += SpeedBoost;
            
            Destroy(gameObject);
        }
    }
}
