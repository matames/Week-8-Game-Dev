using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D myBody;
    public float speed;
    public Animator menuAnim;

    // Update is called once per frame
    void Update()
    {
        MoveKeys();
    }

    void MoveKeys()
    {

        if(menuAnim.GetBool("menuUp") == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                LRmove(-speed);
            }

            if (Input.GetKey(KeyCode.D))
            {
                LRmove(speed);
            }
        }
    }

    void LRmove(float direction) //for movement left right
    {
        myBody.velocity = new Vector3(direction, myBody.velocity.y);
    }


}
