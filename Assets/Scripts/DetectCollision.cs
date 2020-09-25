using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
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
