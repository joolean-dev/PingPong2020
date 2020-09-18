using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject validCourt;
    private Touch touch;

    //float maxAxisX, maxAxisY;
    public int resWidth, resHeight;

    Vector3 camPos;
    void Start()
    {
        resWidth = Screen.currentResolution.width;
        resHeight = Screen.currentResolution.height;
        //maxAxisX = validCourt.transform.localScale.x;
        //maxAxisY = validCourt.transform.localScale.z;
    }

    // Update is called once per frame
    void Update()
    {

        if (/*Input.touchCount > 0 ||*/ Input.GetMouseButtonDown(0))
        {
            //touch = Input.GetTouch(0);
            camPos = Camera.main.WorldToScreenPoint(touch.position);
            transform.position = camPos;

        /*  Vector3 newDestination = new Vector3(
                touch.position.x * maxAxisX / 1920f - (maxAxisX / 2),
                this.transform.position.y,
                touch.position.y * maxAxisY / 1080f - ((maxAxisY / 2 + transform.localScale.z))   );
            
            transform.position = newDestination;    */
        }
    } 
}
