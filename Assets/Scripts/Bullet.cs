using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10),ForceMode2D.Impulse);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
