using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterdestory : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "water")
        {
            Destroy(this.gameObject);
        }
    }
}
