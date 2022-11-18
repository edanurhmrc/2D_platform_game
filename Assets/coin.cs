using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
       audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            audioSource.Play();
            Invoke("DestroyObject", 0.4f);

        }
    }
    void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
