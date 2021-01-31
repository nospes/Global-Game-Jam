using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cameramove : MonoBehaviour
{
    public int moveAmount;
    public Vector3 cameraFollowPosition;
    public int minscreenbound;
    public int maxscreenbound;

    // Start is called before the first frame update
    void Start()
    {
        minscreenbound = 0;
        maxscreenbound = 9;
        moveAmount = 4;
        cameraFollowPosition = Camera.main.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float edgeSize = 30f;

        if (cameraFollowPosition.x < maxscreenbound)
        {
            if (Input.mousePosition.x > Screen.width - edgeSize)
            {
                cameraFollowPosition.x += moveAmount * Time.deltaTime;
                Camera.main.transform.position = cameraFollowPosition;
            }
        }

        if (cameraFollowPosition.x > minscreenbound)
        {
            if (Input.mousePosition.x < edgeSize)
            {
                cameraFollowPosition.x -= moveAmount * Time.deltaTime;
                Camera.main.transform.position = cameraFollowPosition;
            }
        }
    }
}
