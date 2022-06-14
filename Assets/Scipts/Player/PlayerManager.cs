using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D rb;
    public Sprite heart_full;
    public Sprite heart_empty;
    Timer timer;

    public int CurrentHP = 3;
    public int MaxHP = 3;
    public int Deaths = 0;

    public float Speed = 5f;
    public float MaxSpeed = 10f;

    public float dodgeCD = 1f;
    public bool Dodge = true;
    public float dodgeTime = 0f;

    private void Awake()
    {
        if (Controller.difficulty == 1) MaxHP = 3;
        if (Controller.difficulty == 2) MaxHP = 1;
        SetHealthMax();
        timer = GameObject.FindGameObjectWithTag("Timer").GetComponent<Timer>();
    }

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
        Deaths++;
        GameObject.FindGameObjectWithTag("DeathCount").GetComponent<Text>().text = $"Deaths: {Deaths}";
        timer.SetTimerValue(timer.timerStandardValue);
        SetHealthMax();
        transform.localPosition = new Vector3(0, -4, 1);
        GameObject.FindObjectOfType<Camera>().GetComponent<RoomManager>().RoomReset(); // This has top be last as it stops the scene from progressing
    }
}
