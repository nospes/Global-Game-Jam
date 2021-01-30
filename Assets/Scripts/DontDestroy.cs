using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DontDestroy : MonoBehaviour
{
    public bool safeopen;

    // don't destroy in scene change & destroy multiple instances of HUD

    private void Awake()
    {
        safeopen = false;
            GameObject[] obj = GameObject.FindGameObjectsWithTag("GameController");

            if (obj.Length > 1)
            {
                Destroy(this.gameObject);
            }

            DontDestroyOnLoad(this.gameObject);

    }

    // check if a item has been looted
    public List<int> itemsIDs;

    public bool ItemCheck(int IDitem)
    {
        bool itemexist = itemsIDs.Contains(IDitem);
        return itemexist;
    }

    public List<int> InteractIDs;

    public bool InteractCheck(int IDiteract)
    {
        bool interact = InteractIDs.Contains(IDiteract);
        return interact;
    }

}
