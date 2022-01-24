using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hallway1 : MonoBehaviour
{
    public bool isInRange;
   

    public GameObject hallwayNotice1;
    public GameObject hallwayNotice2;
    public GameObject hallwayNotice3;
    public GameObject hallwayNotice4;
    // Start is called before the first frame update
    void Start()
    {
        hallwayNotice1.SetActive(false);
        hallwayNotice2.SetActive(false);
        hallwayNotice3.SetActive(false);
        hallwayNotice4.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Hallway1"))
        {
            isInRange = true;
            hallwayNotice1.SetActive(true);

        }else if (collision.gameObject.CompareTag("Hallway2"))
        {
            isInRange = true;
            hallwayNotice2.SetActive(true);

        }else if (collision.gameObject.CompareTag("Hallway3"))
        {
            isInRange = true;
            hallwayNotice3.SetActive(true);

        }else if (collision.gameObject.CompareTag("Hallway4"))
        {
            isInRange = true;
            hallwayNotice4.SetActive(true);

        }

    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Hallway1"))
        {
            isInRange = false;
            hallwayNotice1.SetActive(false);
        }else if (collision.gameObject.CompareTag("Hallway2"))
        {
            isInRange = false;
            hallwayNotice2.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Hallway3"))
        {
            isInRange = false;
            hallwayNotice3.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("Hallway4"))
        {
            isInRange = false;
            hallwayNotice4.SetActive(false);
        }
    }
}
