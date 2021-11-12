using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody2D myBody;
    public float speed;
    public Animator menuAnim;

    public GameObject pageManager;

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


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "newPage")
        {

            pageManager.GetComponent<JournalManager>().pagesMax += 1;
            pageManager.GetComponent<JournalManager>().pageSprite.Add(collision.gameObject.GetComponent<SpriteRenderer>().sprite);
            Destroy(collision.gameObject);
                
        }
    }


}
