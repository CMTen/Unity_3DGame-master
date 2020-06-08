﻿using UnityEngine;

public class Bullet : MonoBehaviour
{
    /// <summary>
    /// 子彈的傷害值
    /// </summary>
    public float damage;

    public bool player; 

    private void OnTriggerEnter(Collider other)
    {
        if (!player && other.name == "機器人")
        {
            other.GetComponent<Player>().Hit(damage);
            Destroy(gameObject);
        }
        else if (player && other.tag == "敵人" && other.GetComponent<Enemy>())
        {
            other.GetComponent<Enemy>().Hit(damage);
            Destroy(gameObject);
        }
    }
}
