using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Defining the interact ID, interact id define with what Items this OBJ interact
    [SerializeField]
    public int interactionid;

    //Define Game OBJ
    GameObject obj;
    GameObject intids;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Inventory");
        intids = GameObject.FindGameObjectWithTag("GameController");
        bool thischeckexist = intids.GetComponent<DontDestroy>().InteractCheck(interactionid);

        if (thischeckexist)
        {
            Destroy(gameObject);
        }

    }

    private void Update()
    {
        bool thischeckexist = intids.GetComponent<DontDestroy>().InteractCheck(interactionid);

        if (thischeckexist)
        {
            Destroy(gameObject);
        }

    }

    //Interacting with specified items
    private void OnMouseDown()
    {
        if(obj.GetComponent<Inventory>().actionid==interactionid)
        {
            obj.GetComponent<Inventory>().actionid = 0;
            intids.GetComponent<DontDestroy>().InteractIDs.Add(interactionid);
            Debug.Log("It Worked!");
            Destroy(gameObject);
        }
    }
}
