using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRoll : MonoBehaviour
{
    public AudioSource se;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        se = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (!rb.IsSleeping()) {
            se.Play();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        se.Stop();
    }
}
