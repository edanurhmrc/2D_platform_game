using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    AudioSource audioSource;
    float hiz = 6f;
    float ziplama = 6f;
    Vector3 velocity;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * hiz * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rigidbody2D.velocity.y, 0))
        {
            rigidbody2D.AddForce(Vector3.up * ziplama, ForceMode2D.Impulse);
            audioSource.Play();
        }
    }
}
