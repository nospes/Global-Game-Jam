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
    public Sprite Heart;
    [SerializeField]
    public Sprite Home;

    

    public void HotbarCheck()
    {
        Sprite objsprite = this.gameObject.transform.GetComponent<Image>().sprite;
        if(objsprite==Heart)
        {
            obj.GetComponent<Inventory>().actionid = 01;
            Debug.Log(obj.GetComponent<Inventory>().actionid);
        }
    }

    // Delete a item from hotbar
    public void HotbarDelet()
    {
        this.gameObject.transform.GetComponent<Image>().sprite = null;
        obj.GetComponent<Inventory>().invslots[hotbarID] = 0; 
    }

}
