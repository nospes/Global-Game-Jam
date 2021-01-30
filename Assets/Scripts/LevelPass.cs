using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelPass : MonoBehaviour
{
    GameObject obj;

    [SerializeField]
    public int roomchange;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("LevelLoad");
    }

    void OnMouseDown()
    {

        obj.GetComponent<LevelLoader>().LoadNextLevel(roomchange);
    }

}
