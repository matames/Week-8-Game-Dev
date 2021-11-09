using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalManager : MonoBehaviour
{
    public Animator myAnim;

    private void Update()
    {
        MenuCheck();   
    }


    void MenuCheck()
    {
        if (Input.GetKey(KeyCode.E))
        {
            myAnim.SetBool("menuUp", true);
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            myAnim.SetBool("menuUp", false);
        }

    }


}
