using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Proximity : MonoBehaviour
{
    public string newTitle;
    public string newAuthor;
    public string newDesc;
    private Transform other;
    private Text myTitle;
    private Text myAuthor;
    private Text myDesc;
    private float dist;
    private GameObject player;
    private GameObject message1;
    private GameObject message2;
    private GameObject message3;
    private bool check;

    
    public Sprite picture1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        other = player.GetComponent<Transform>();
        message1 = GameObject.FindWithTag("ArtTitle");
        message2 = GameObject.FindWithTag("ArtAuthor");
        message3 = GameObject.FindWithTag("ArtDescription");
        myTitle = message1.GetComponent<Text>();
        myTitle.text = "";
        myAuthor = message2.GetComponent<Text>();
        myAuthor.text = "";
        myDesc = message3.GetComponent<Text>();
        myDesc.text = "";
        check = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (other)
        {
            dist = Vector3.Distance(transform.position, other.position);
            
            if (dist < 4.5)
            {
                myTitle.text = newTitle;
                myAuthor.text = newAuthor;
                myDesc.text = newDesc;
                check = true;
            }
            if (dist > 4.5 && check == true)
            {
                Start();
            }
        }
    }

    public void printMessage()
    {
        PopUpSystem pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUpSystem>();
        pop.PopUp(picture1);
        
    }
}
