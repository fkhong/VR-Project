using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Video;

public class VideoPlayer : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;

    public GameObject video1;
    public GameObject videoNotice; 


    // Start is called before the first frame update
    void Start()
    {
        video1.SetActive(false);
        videoNotice.SetActive(false);
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

    public void videoTrigger()
    {
        if (video1.activeSelf == false)
        {
            video1.SetActive(true);
            videoNotice.SetActive(false);
        } 

        else if (video1.activeSelf == true)
        {
            video1.SetActive(false);
        }
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            videoNotice.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            videoNotice.SetActive(false);
        }
    }
}
