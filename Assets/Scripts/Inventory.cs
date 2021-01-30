using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Inventory : MonoBehaviour
{



    // Invetory merge items

    //Sprites that can merge
    [SerializeField]
    public Sprite Mergeditem1;
    [SerializeField]
    public Sprite Mergeditem2;
    
    //Variables to store sprites
    Sprite objmerge;
    Sprite objmerge2;

    //Check if the item's can merge
    private bool itemmergebool1;
    private bool itemmergebool2;

    //Result of merges
    [SerializeField]
    Sprite resultmerge1;


    public void Invmerge()
    {
        int i = 0;
        int h = 0;
        while(i<8)
        {
            objmerge = this.gameObject.transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<Image>().sprite;
            if (objmerge==Mergeditem1)
            {
                itemmergebool1 = true;
                break;
            }
            else i++;
        }

        while(h<8)
        {
            objmerge2 = this.gameObject.transform.GetChild(h).GetChild(0).GetChild(0).GetComponent<Image>().sprite;
            if (objmerge2 == Mergeditem2)
            {
                itemmergebool2 = true;
                break;
            }
            else h++;
        }
        if((itemmergebool1)&&(itemmergebool2))
        {
            this.gameObject.transform.GetChild(i).GetChild(0).GetChild(0).GetComponent<HotbarClick>().HotbarDelet();
            this.gameObject.transform.GetChild(h).GetChild(0).GetChild(0).GetComponent<HotbarClick>().HotbarDelet();
            this.Invstore(resultmerge1);
        }

    }

    // Inventory Organizer

    public int[] invslots;
    public int invused;
    GameObject objslot;


    private void Awake()
    {
        invslots = new int[8];
    }



    public void Invstore(Sprite objImage)
    {
        int freearray = System.Array.IndexOf(invslots, 0);
        invused = freearray;
        objslot = this.gameObject.transform.GetChild(invused).gameObject;
        if (freearray != -1)
        {
            objslot.transform.GetChild(0).GetChild(0).GetComponent<Image>().sprite = objImage;
            invslots[invused] = 1;
            Debug.Log(invused);
            Debug.Log(invslots);
        }
    }

    // Interaction Action reset

    public int actionid;

    private void LateUpdate()
    {
        if (Input.GetMouseButtonDown(0)&&actionid!=0)
        {
            actionid = 0;
            Debug.Log(actionid);
        }
    }

}
