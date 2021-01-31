using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endgame : MonoBehaviour
{
    private void Awake()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("GameController");
        Destroy(obj);
    }

    public void ToggleAnalog()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
