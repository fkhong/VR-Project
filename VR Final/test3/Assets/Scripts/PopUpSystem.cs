using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpSystem : MonoBehaviour
{
    public GameObject popUpBox;
    public Animator animator;
    
    public Image picture; 

    public void PopUp(Sprite picture1)
    {
        popUpBox.SetActive(true);
        
        picture.sprite = picture1;
        animator.SetTrigger("pop");
    } 

   
}
