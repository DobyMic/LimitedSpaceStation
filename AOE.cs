using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AOE : MonoBehaviour
{

    private void OnTriggerEnter2D ( Collider2D collision )
    {
        if(collision.tag == "Player")
        {
            collision . GetComponent<Player> () . TakeDamage ((int)Random.Range(1,10));
        }
    }
}
