using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightControl : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey1;
    public KeyCode interactKey2;
    public UnityEvent interactAction1;
    public UnityEvent interactAction2;

    public GameObject LightNotice;
    public GameObject Light;
    // Start is called before the first frame update
    void Start()
    {
        LightNotice.SetActive(false);
        Light.SetActive(false);
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

            if (Input.GetKeyDown(interactKey2))
            {
                interactAction2.Invoke();
            }
        }
    }

    public void SetLightOn()
    {
        Light.SetActive(true);
    }

    public void SetLightOff()
    {
        Light.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            LightNotice.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            LightNotice.SetActive(false);
        }
    }
}
