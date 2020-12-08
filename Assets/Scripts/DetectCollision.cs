using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public Rigidbody rb;
    //public Rigidbody ballRb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        // If Ball collides with either goal, destroy it
        if (other.gameObject.name == "Ball")
        {
          switch (gameObject.tag)
            {
                case "Player Goal":
                    Debug.Log("Pico en Player Goal");
                    break;
                case "Enemy Goal":
                    Debug.Log("Pico en Enemy Goal");
                    break;
            }
        }

        if (other.gameObject.tag == "Player") { 
        switch (gameObject.tag)
        {
            case "plus1sec":
                TimeLeft.timeLeft += 3f;
                //DestroyObject(gameObject);
                Object.Destroy(gameObject);
                break;
            case "minus2sec":
                TimeLeft.timeLeft -= 2f;
                //DestroyObject(gameObject);
                Destroy(gameObject);
                break;
            }
        }
        
    }
}
