using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{

    public float speed = 5f;

    public GameObject Weapon;
    //public GameObject WeaponPrefab;
    private Player player;

    Vector2 mousePos;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    private void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(Weapon != player.equippedWeapon) Weapon = player.equippedWeapon;
        if(player.weaponTransform != transform) player.weaponTransform = transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 lookDir = mousePos - (Vector2)transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg + 90;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotation;
    }   
}
