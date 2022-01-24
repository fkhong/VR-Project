using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FamousArt : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey1;
    
    public UnityEvent interactAction1;
    

    public GameObject famousNotice;
    public GameObject famousArt;
    // Start is called before the first frame update
    void Start()
    {
        famousNotice.SetActive(false);
        famousArt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey1))
            {
                interactAction1.Invoke();
            }

            
        }
    }

    public void FamousDesc()
    {
        if (famousArt.activeSelf== false)
        {
            famousArt.SetActive(true);
        }else if (famousArt.activeSelf == true)
        {
            famousArt.SetActive(false);
        }

    }

    

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            famousNotice.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            famousNotice.SetActive(false);
        }
    }
}
