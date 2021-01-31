using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OBJlock : MonoBehaviour
{
    GameObject obj;
    // Start is called before the first frame update
    public void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("OBJitem");
        obj.GetComponent<ObjectivePickup>().tangible = false;

        GameObject intids = GameObject.FindGameObjectWithTag("GameController");
        int inteid = this.gameObject.GetComponent<Interact>().interactionid;

        bool thischeckexist = intids.GetComponent<DontDestroy>().InteractCheck(inteid);

        if (thischeckexist)
        {
            obj.GetComponent<ObjectivePickup>().tangible = true;
        }
    }

    private void Update()
    {
        GameObject intids = GameObject.FindGameObjectWithTag("GameController");
        int inteid = this.gameObject.GetComponent<Interact>().interactionid;

        bool thischeckexist = intids.GetComponent<DontDestroy>().InteractCheck(inteid);

        if (thischeckexist)
        {
            obj.GetComponent<ObjectivePickup>().tangible = true;
        }
    }

}

