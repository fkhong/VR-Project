using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InfoBoard : MonoBehaviour
{
    public bool isInRange;

    public GameObject infoBoard;
    // Start is called before the first frame update
    void Start()
    {
        infoBoard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            infoBoard.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            infoBoard.SetActive(false);
        }
    }
}
