using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject validCourt;
    private Touch touch;

    float maxAxisX, maxAxisY;
    public int resWidth, resHeight;

    Vector3 camPos;
    void Start()
    {
        /* resWidth = Screen.currentResolution.width;
        resHeight = Screen.currentResolution.height; */
        resWidth = 1920;
        resHeight = 1080;

        maxAxisX = 12.0f;
        maxAxisY = 6.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            //camPos = Camera.main.WorldToScreenPoint(touch.position);
            //transform.position = camPos;

          transform.position = new Vector3(
                touch.position.x * maxAxisX / 1920f - (maxAxisX / 2),
                transform.position.y,
                touch.position.y * maxAxisY / 1080f - (maxAxisY / 2)    );

        }
    } 
}
