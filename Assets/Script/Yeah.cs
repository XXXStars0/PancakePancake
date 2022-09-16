using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yeah : MonoBehaviour
{
    public Animator a;
    public AudioSource se;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        a.SetBool("yeah",true);
        se.Play();
        print(other);
    }
}
