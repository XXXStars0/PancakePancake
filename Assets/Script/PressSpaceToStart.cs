using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressSpaceToStart : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public GameObject cam1;
    public AudioSource se;
    bool tag = false;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&tag==false)
        {
            tag = true;
            rb.isKinematic = false;
            cam1.SetActive(true);
            se.Play();
        }
    }
}
