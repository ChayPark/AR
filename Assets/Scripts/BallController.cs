using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f;        // starting speed value
    public float weight = 1f;
    public float moveDistance = 1f;

    private Rigidbody rb;
    private bool isLaunched = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = weight;
    }

    public void Launch()
    {
        isLaunched = true;
        rb.AddForce(new Vector3(0, 0, 1) * speed, ForceMode.Impulse);
    }

    public void Reset()
    {
        isLaunched = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = Vector3.zero;
    }

    public void IncreaseSpeed()
    {
        speed += 1;
    }

    public void DecreaseSpeed()
    {
        speed -= 1;
    }

    public void AdjustWeight(float newWeight)
    {
        weight = newWeight;
        rb.mass = weight;
    }

    public void MoveBall(string direction)
    {
        if (!isLaunched)
        {
            switch (direction)
            {
                case "Right":
                    transform.position += new Vector3(0, 0, moveDistance);
                    break;
                case "Left":
                    transform.position -= new Vector3(0, 0, moveDistance);
                    break;
            }
        }
    }
}