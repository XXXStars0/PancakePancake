using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShift2 : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;

    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(true);
        cam4.SetActive(false);
        cam5.SetActive(false);
    }
}
