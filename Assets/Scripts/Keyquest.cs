using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyquest : MonoBehaviour
{
    GameObject ghost;
    public Sprite ghostimg;

    public Sprite Image
    {
        get { return ghostimg; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        ghost = GameObject.FindGameObjectWithTag("Item");
        ghost.GetComponent<Pickup>().tangible = false;
    }

    void OnDestroy()
    {
            ghost.transform.GetComponent<SpriteRenderer>().sprite = ghostimg;
            ghost.GetComponent<Pickup>().tangible = true;
    }
}
