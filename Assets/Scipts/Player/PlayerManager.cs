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
    public int Deaths = -1;

    public float Speed = 5f;
    public float MaxSpeed = 10f;

    public bool invinciblePhase = false;

    private void Awake()
    {
        if (Controller.difficulty == 1) MaxHP = 3;
        if (Controller.difficulty == 2) MaxHP = 1;
        SetHealthMax();
    }

    private void Start()
    {
        Death();
    }

    public void TakeDamage(int damage)
    {
        if (invinciblePhase) return;

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
        Deaths++;
        GameObject.FindGameObjectWithTag("DeathCount").GetComponent<Text>().text = $"Deaths: {Deaths}";
        SetHealthMax();
        GameObject.FindObjectOfType<Camera>().GetComponent<RoomManager>().RoomReset(); // This has top be last as it stops the scene from progressing
    }

    public void SetPosition(Vector3 vector)
    {
        gameObject.transform.position = vector;
    }
}
