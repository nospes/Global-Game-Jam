using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePickup : MonoBehaviour
{
    // Defining itemID & Sprite

    [SerializeField]
    public int itemID;
    public Sprite SImage;
    public bool tangible = true;

    public Sprite Image
    {
        get { return SImage; }
    }

    // defining Gameobjs and if the item has been aleardy looted, destroy him

    GameObject obj;
    GameObject objids;

    private void Awake()
    {

        obj = GameObject.FindGameObjectWithTag("OBJInventory");
        objids = GameObject.FindGameObjectWithTag("GameController");

        bool checkexist = objids.GetComponent<DontDestroy>().ItemCheck(itemID);

        if (checkexist)
        {
            Destroy(gameObject);
        }

    }

    private void Update()
    {
    }

    // Pickup obj to inventory
    void OnMouseDown()
    {
        if (tangible)
        {
            obj.GetComponent<OBJInventory>().Invstore(SImage);
            objids.GetComponent<DontDestroy>().itemsIDs.Add(itemID);
            Destroy(gameObject);
        }
    }
}
