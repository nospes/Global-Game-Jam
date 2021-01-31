using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotbarClick : MonoBehaviour
{
    //Defining Hotbarid & gameobjs
    [SerializeField]
    public int hotbarID;
    GameObject obj;


    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Inventory");
    }

    // Defining action id of items based on sprite

    [SerializeField]
    public Sprite Crowbar;
    [SerializeField]
    public Sprite Imaextend;
    [SerializeField]
    public Sprite Key;
    [SerializeField]
    public Sprite Hammer;



    public void HotbarCheck()
    {
        Sprite objsprite = this.GetComponent<Image>().sprite;
        if(objsprite==Crowbar)
        {
            obj.GetComponent<Inventory>().actionid = 101;
            Debug.Log(obj.GetComponent<Inventory>().actionid);
        }
        if (objsprite == Imaextend)
        {
            obj.GetComponent<Inventory>().actionid = 102;
            Debug.Log(obj.GetComponent<Inventory>().actionid);
        }
        if (objsprite == Key)
        {
            obj.GetComponent<Inventory>().actionid = 103;
            Debug.Log(obj.GetComponent<Inventory>().actionid);
        }
        if (objsprite == Hammer)
        {
            obj.GetComponent<Inventory>().actionid = 104;
            Debug.Log(obj.GetComponent<Inventory>().actionid);
        }
    }

    // Delete a item from hotbar
    public void HotbarDelet()
    {
        this.GetComponent<Image>().sprite = null;
        obj.GetComponent<Inventory>().invslots[hotbarID] = 0; 
    }

}
