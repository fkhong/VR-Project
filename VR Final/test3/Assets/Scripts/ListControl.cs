using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ListControl : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    public GameObject list;
    public GameObject listNotice;
    // Start is called before the first frame update
    void Start()
    {
        list.SetActive(false);
        listNotice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                interactAction.Invoke();
            }
        }
    }

    public void listTrigger()
    {
        if (list.activeSelf == false)
        {
            list.SetActive(true);
            
        }

        else if (list.activeSelf == true)
        {
            list.SetActive(false);
        }

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            listNotice.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            listNotice.SetActive(false);
        }
    }
}
