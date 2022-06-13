using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public Sprite heart_full;
    public Sprite heart_empty;

    public int CurrentHP = 3;
    public int MaxHP = 3;
    public int Deaths = 0;

    public float Speed = 5f;
    public float MaxSpeed = 10f;

    public float dodgeCD = 1f;
    public bool Dodge = true;
    public float dodgeTime = 0f;

    public void TakeDamage(int damage)
    {
        CurrentHP -= damage;

        if (CurrentHP <= 0)
        {
            Death();
        }
    }

    public void GainHealth(int amount)
    {
        CurrentHP += amount;
        if (CurrentHP > MaxHP) CurrentHP = MaxHP;
    }

    public void SetHealthMax()
    {
        CurrentHP = MaxHP;
    }

    public void Death()
    {
        GameObject.FindGameObjectWithTag("DeathCount").GetComponent<Text>().text = $"Deaths: {Deaths}";
        Deaths++;
        CurrentHP = MaxHP;
        GameObject.FindGameObjectWithTag("Player").transform.localPosition = new Vector3(0, -4, -1);
        GameObject.Find("Background").GetComponent<RoomManager>().RoomReset();
    }
}
