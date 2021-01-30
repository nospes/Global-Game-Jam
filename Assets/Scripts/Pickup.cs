using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    // Defining itemID & Sprite

    [SerializeField]
    public int itemID;
    public Sprite SImage;
    public bool tangible = true;

    public Sprite Image
    {
        get { return SImage;}
    }

    // defining Gameobjs and if the item has been aleardy looted, destroy him

    GameObject obj;
    GameObject objids;

    private void Awake()
    {
        
       obj = GameObject.FindGameObjectWithTag("Inventory");
       objids = GameObject.FindGameObjectWithTag("GameController");

        bool checkexist = objids.GetComponent<DontDestroy>().ItemCheck(itemID);

        if (checkexist)
        {
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        bool checkexist = objids.GetComponent<DontDestroy>().ItemCheck(itemID);

        if (checkexist)
        {
            Destroy(gameObject);
        }

    }

    // Pickup obj to inventory
    void OnMouseDown()
    {
        if (tangible)
        {
            obj.GetComponent<Inventory>().Invstore(SImage);
            objids.GetComponent<DontDestroy>().itemsIDs.Add(itemID);
            obj.GetComponent<Inventory>().Invmerge();
            Destroy(gameObject);
        }
    }
}
