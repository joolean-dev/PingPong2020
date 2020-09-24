using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public float speed = 0.1f;
    private Rigidbody rb;
    //Sin uso de la función Start
    /* void Start()
    {

    } */

    // Update is called once per frame
    void Update()
    {
        
            //The screen has been touched so store the touch
            
            if (Input.GetMouseButton(0))
            {
                // If the finger is on the screen, move the object smoothly to the touch 
                Plane plane = new Plane(Vector3.up, transform.position);
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

                float dist;
                if (plane.Raycast(ray, out dist))
                {
                    transform.position = ray.GetPoint(dist);
                    //Debug.Log("In the inside");


                    //Vector3 dir = new Vector3(touch.position.x, transform.position.y, touch.position.y) - transform.position;
                    //float angle = Mathf.Atan2(dir.z, dir.x) * Mathf.Rad2Deg;
                    //transform.rotation = Quaternion.AngleAxis(angle, Vector3.up);
                    //Debug.Log("Angulo: " + angle);
                }
            }
        
    }

    private void OnTriggerEnter(Collider other)
    {

        rb = other.attachedRigidbody;

        //rb.AddForce(-0.3f, 0.3f, 0);
        AddForceAtAngle(-0.3f, 90f, rb);
    }

    public void AddForceAtAngle(float force, float angle, Rigidbody rb)
    {
        float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * force;
        float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * force;

        rb.AddForce(ycomponent, 0, xcomponent);
    }
}