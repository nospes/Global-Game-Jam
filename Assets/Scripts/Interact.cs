using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // Defining the interact ID, interact id define with what Items this OBJ interact
    [SerializeField]
    public int interactionid;

    [SerializeField]
    public Sprite newSprite;

    //Define Game OBJ
    GameObject obj;
    GameObject intids;

    public Sprite Image
    {
        get { return newSprite; }
    }

    private void Awake()
    {
        audioplay = GetComponent<AudioSource>();

        obj = GameObject.FindGameObjectWithTag("Inventory");
        intids = GameObject.FindGameObjectWithTag("GameController");
        bool thischeckexist = intids.GetComponent<DontDestroy>().InteractCheck(interactionid);

        if (thischeckexist)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 70);
            if (newSprite==null)
            Destroy(gameObject);
            else
            this.GetComponent<SpriteRenderer>().sprite = newSprite;
        }

    }

    private void Update()
    {
        bool thischeckexist = intids.GetComponent<DontDestroy>().InteractCheck(interactionid);
        if (thischeckexist)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 70);
            if (newSprite==null)
            Destroy(gameObject);
            else
            this.GetComponent<SpriteRenderer>().sprite = newSprite;
        }

    }

    //aduios
    private AudioSource audioplay;
    public AudioClip hammer;
    public AudioClip box;

    //Interacting with specified items
    void OnMouseDown()
    {
        if (obj.GetComponent<Inventory>().actionid == 104)
        {
            if (obj.GetComponent<Inventory>().actionid == interactionid)
            {
                audioplay.PlayOneShot(hammer, 0.7f);
                audioplay.PlayOneShot(box, 0.7f);
            }
        }

        if (obj.GetComponent<Inventory>().actionid==interactionid)
        {
            Debug.Log("It Worked!");

            intids.GetComponent<DontDestroy>().InteractIDs.Add(interactionid);
        }
        else
            obj.GetComponent<Inventory>().actionid = 0;
    }
}
