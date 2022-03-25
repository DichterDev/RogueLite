using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingBow : MonoBehaviour
{
    public PlayerManager Player;
    public GameObject ArrowPrefab;
    public ProjectileManager projectileManager;
    public BowManager bowManager;

    private float PlayerDrawTime;
    private float time1;
    private float time2;
    private float DrawTime;
    private float percent;
    private void Update()
    {
        PlayerDrawTime = bowManager.DrawTime * Player.attackSpeed;
        if (Input.GetMouseButtonDown(0))
        {
            time1 = Time.time;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            time2 = Time.time;
            DrawTime = time2 - time1;
            if (DrawTime > PlayerDrawTime)
            {
                DrawTime = bowManager.DrawTime;
                percent = 1f;
            }
            else
            {
                percent = DrawTime / PlayerDrawTime;    
            }
        }
    }

    void Shoot(float percentage)
    {
        GameObject arrow = Instantiate(projectileManager.Projectile, projectileManager.firePoint.position, projectileManager.firePoint.rotation);
        arrow.name = Mathf.Round(projectileManager.Damage * percentage).ToString();
        arrow.tag = "Projectile";
        Rigidbody2D rb = arrow.GetComponent<Rigidbody2D>();
        rb.AddForce(projectileManager.firePoint.up * projectileManager.ProjForce, ForceMode2D.Impulse);
        Destroy(arrow, projectileManager.ProjTime * percentage);
    }
}
