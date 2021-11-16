using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talking : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) //if you press the up arrow, the y transform position of the object will increase by the variable speed multiplied by time
        {
            anim.SetBool("Talking", true);
        }

        if (Input.GetKey(KeyCode.DownArrow)) //if you press the up arrow, the y transform position of the object will increase by the variable speed multiplied by time
        {
            anim.SetBool("Talking", false);
        }
    }
}
