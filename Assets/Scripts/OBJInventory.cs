using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OBJInventory : MonoBehaviour
{
    // Inventory Organizer

    public int[] invslots;
    public int invused;
    GameObject objslot;
    [SerializeField]
    public int roomchange;


    private void Awake()
    {
        invslots = new int[3];
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
        }
        if(invslots[2]==1)
        {
            GameObject levelobj = GameObject.FindGameObjectWithTag("LevelLoad");
            levelobj.GetComponent<LevelLoader>().LoadNextLevel(roomchange);
        }
    }

}
