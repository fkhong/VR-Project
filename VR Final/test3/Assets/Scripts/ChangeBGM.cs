using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeBGM : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey0;
    public KeyCode interactKey1;
    public KeyCode interactKey2;
    public KeyCode interactKey3;
    public KeyCode interactKey4;
    public KeyCode interactKey5;
    public UnityEvent interactAction0;
    public UnityEvent interactAction1;
    public UnityEvent interactAction2;
    public UnityEvent interactAction3;
    public UnityEvent interactAction4;
    public UnityEvent interactAction5;

    public GameObject BGM1;
    public GameObject BGM2;
    public GameObject BGM3;
    public GameObject BGM4;
    public GameObject selectBoard;
    public GameObject changeBGMNotice; 
    // Start is called before the first frame update
    void Start()
    {
        BGM1.SetActive(false);
        BGM2.SetActive(false);
        BGM3.SetActive(false);
        BGM4.SetActive(false);
        selectBoard.SetActive(false);
        changeBGMNotice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey0))
            {
                interactAction0.Invoke();
            }
            if (Input.GetKeyDown(interactKey1))
            {
                interactAction1.Invoke();
            }

            if (Input.GetKeyDown(interactKey2))
            {
                interactAction2.Invoke();
            }
            if (Input.GetKeyDown(interactKey3))
            {
                interactAction3.Invoke();
            }
            if (Input.GetKeyDown(interactKey4))
            {
                interactAction4.Invoke();
            }
            if (Input.GetKeyDown(interactKey5))
            {
                interactAction5.Invoke();
            }

        }
    }

    public void SetBGM1()
    {
        BGM1.SetActive(true);
        BGM2.SetActive(false);
        BGM3.SetActive(false);
        BGM4.SetActive(false);
    }
    public void SetBGM2()
    {
        BGM1.SetActive(false);
        BGM2.SetActive(true);
        BGM3.SetActive(false);
        BGM4.SetActive(false);
    }
    public void SetBGM3()
    {
        BGM1.SetActive(false);
        BGM2.SetActive(false);
        BGM3.SetActive(true);
        BGM4.SetActive(false);
    }
    public void SetBGM4()
    {
        BGM1.SetActive(false);
        BGM2.SetActive(false);
        BGM3.SetActive(false);
        BGM4.SetActive(true);
    }

    public void closeAll()
    {
        BGM1.SetActive(false);
        BGM2.SetActive(false);
        BGM3.SetActive(false);
        BGM4.SetActive(false);
    }
    public void DisplayChange()
    {
        selectBoard.SetActive(true);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            changeBGMNotice.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            changeBGMNotice.SetActive(false);
            selectBoard.SetActive(false);
        }
    }
}
