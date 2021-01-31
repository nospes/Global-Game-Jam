using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeElapsed;

    public Text text;

    void Start()
    {
        timeElapsed = 0f;
        text = GetComponent<Text>();
    }

    // Update is called once per fram$
    void Update()
    {
        timeElapsed += Time.deltaTime;
        
        text.text = secToMinutes(timeElapsed);
    }

    string secToMinutes(float seconds)
    {
        var min = (Mathf.Floor(seconds/60)).ToString().PadLeft(2,'0');
        var secs = Mathf.Floor(seconds%60).ToString().PadLeft(2,'0');
        return $"{min}:{secs}";
    }
}
