using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logobehavior : MonoBehaviour
{
    GameObject obj;
    [SerializeField] public int roomchangen;

    private void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("LevelLoad");
    }

    // Start is called before the first frame update
    public void ToggleAnalog()
    {
        obj.GetComponent<LevelLoader>().LoadNextLevel(roomchangen);
    }

    // Update is called once per frame
    public void ToggleAnalog2()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }
}
