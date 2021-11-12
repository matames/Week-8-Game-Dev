using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;


public class JournalManager : MonoBehaviour
{
    public Animator myAnim;
    public List<Sprite> pageSprite;

    public GameObject pg1;
    public GameObject pg2;

    public int leftPageIndex = 0;
    public int rightPageIndex = 1;
   
    public GameObject newPageLeft;
    public GameObject newPageRight;

    public int pagesMax = 9;
    public float alpha;
    
    private void Start()
    {
        newPageLeft.transform.position = new Vector3(pg1.transform.position.x, pg1.transform.position.y);
        newPageLeft.transform.SetParent(pg1.transform);
        newPageLeft.GetComponent<SpriteRenderer>().sprite = pageSprite[leftPageIndex];

        newPageRight.transform.position = new Vector3(pg2.transform.position.x, pg2.transform.position.y);
        newPageRight.transform.SetParent(pg2.transform);
        newPageRight.GetComponent<SpriteRenderer>().sprite = pageSprite[rightPageIndex];
    }


    private void Update()
    {
        MenuCheck();
        turnPageKeys();
        pg2Checker();

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
                if (Input.GetKeyDown(KeyCode.A) && rightPageIndex > 1.9)
                {
                    rightPageIndex -= 2;
                    leftPageIndex -= 2;
                    pageInit(newPageLeft, pg1, leftPageIndex);
                    pageInit(newPageRight, pg2, rightPageIndex);
                }
                //display previous 2 units of array
            }

            if (Input.GetKey(KeyCode.D) && rightPageIndex < pagesMax)
            {
                Debug.Log("next");
                if (Input.GetKeyDown(KeyCode.D))
                {
                    rightPageIndex += 2;
                    leftPageIndex += 2;
                    pageInit(newPageLeft, pg1, leftPageIndex);
                    pageInit(newPageRight, pg2, rightPageIndex);
                }
                //display next two units of array
            }
        }

    }

    void pageInit(GameObject pageType, GameObject pagePlacement, int pageIndex)
    {
        pageType.transform.position = new Vector3(pagePlacement.transform.position.x, pagePlacement.transform.position.y);
        pageType.transform.SetParent(pagePlacement.transform);
        pageType.GetComponent<SpriteRenderer>().sprite = pageSprite[pageIndex];
    }


    void pg2Checker()
    {
       
        if (pagesMax == (pageSprite.Count - 1))
        {
            newPageRight.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
        } else
        {
            newPageRight.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0f);
        }

        
    }


}
