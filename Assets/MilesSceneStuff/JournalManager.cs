using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalManager : MonoBehaviour
{
    public Animator myAnim;
 

    private void Update()
    {
        MenuCheck();
        turnPageKeys();
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

    void turnPageKeys()
    {

        if(myAnim.GetBool("menuUp") == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Debug.Log("back");
                //display previous 2 units of array
            }

            if (Input.GetKey(KeyCode.D))
            {
                Debug.Log("next");
                //display next two units of array
            }
        }

    }


}
