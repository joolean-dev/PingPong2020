using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 0.1f;
    private Rigidbody rb;
    //Sin uso de la función Start
    /* void Start()
    {

    } */

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0) {
            //The screen has been touched so store the touch
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                // If the finger is on the screen, move the object smoothly to the touch 
                Plane plane = new Plane(Vector3.up, transform.position);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                float dist;
                if (plane.Raycast (ray, out dist)){
                    transform.position = ray.GetPoint (dist);
                }
            }
        }
    } 

    private void OnTriggerEnter(Collider other) {
        rb = other.attachedRigidbody;

        rb.AddForce(-0.02f, 0.03f, 0);
    }
}
