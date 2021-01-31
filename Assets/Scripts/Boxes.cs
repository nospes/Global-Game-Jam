using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxes : MonoBehaviour
{
    GameObject obj;
    GameObject itemobj;
    [SerializeField]
    public Sprite newSprite;




    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("Medium");
        itemobj = GameObject.FindGameObjectWithTag("Item");
        itemobj.GetComponent<Pickup>().tangible = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool checkexist = obj.GetComponent<mediumstate>().Nailquest();

        if (checkexist)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 70);
            itemobj.GetComponent<Pickup>().tangible = true;
            this.GetComponent<SpriteRenderer>().sprite = newSprite;

        }
    }
}
