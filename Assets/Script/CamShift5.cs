using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShift5 : MonoBehaviour
{
    public GameObject cam1;
public GameObject cam2;
public GameObject cam3;
public GameObject cam4;
public GameObject cam5;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
{
    cam1.SetActive(false);
    cam2.SetActive(false);
    cam3.SetActive(false);
    cam4.SetActive(false);
    cam5.SetActive(true);
        rb.isKinematic = true;
    }

// Update is called once per frame
void Update()
{

}

private void OnTriggerEnter2D(Collider2D collision)
{
        if (collision.gameObject.name == "Ball (10)") {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(true);
            rb.isKinematic = false;
        }
    }
}
