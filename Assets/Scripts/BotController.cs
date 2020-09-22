using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
    float speed = 40;
    public Transform ball;

    public GameObject table;

    // float force = 13;
    Vector3 targetPosition;

    ShotManager shotManager;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position;
        shotManager = GetComponent<ShotManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        targetPosition.z = ball.position.z;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    Vector3 PickTarget()
    {
        var offsetForward = table.transform.forward.z * (table.transform.localScale.z / 2f) * -1f;
        var posZMin = table.transform.position.z - offsetForward;
        var posZMax = table.transform.position.z + offsetForward;

        var offsetLeft = table.transform.right.x * (table.transform.localScale.x / 2f) * -1f;
        var posXMin = table.transform.position.x - offsetLeft;
        var posXMax = table.transform.position.x + offsetLeft;

        var posZ = Random.Range(posZMin, posZMax);
        var posX = Random.Range(posXMin, posXMax);

        var targetPosition = new Vector3(posX, table.transform.position.y, posZ);

        return targetPosition;
    }

    Shot PickShot()
    {
        int randomValue = Random.Range(0, 2);
        if (randomValue == 0)
        {
            return shotManager.topSpin;
        }
        else
        {
            return shotManager.flat;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            var currentShot = PickShot();

            var dir = PickTarget() - transform.position;
            other.GetComponent<Rigidbody>().velocity = dir.normalized * currentShot.hitForce + new Vector3(0, currentShot.upForce, 0);
        }
    }
}
