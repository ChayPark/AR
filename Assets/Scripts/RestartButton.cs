using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject pinPrefab;
    public GameObject ball;

    private GameObject[] pins;
    private Vector3[] initialPinPositions;
    private Vector3 initialBallPosition;

    private Rigidbody ballRigidbody;

    public BallController ballController;

    private void Start()
    {
        // Get the current pins in the scene
        pins = GameObject.FindGameObjectsWithTag("Pin");

        // Initialize the array for initial positions
        initialPinPositions = new Vector3[pins.Length];

        for (int i = 0; i < pins.Length; i++)
        {
            // Save initial positions
            initialPinPositions[i] = pins[i].transform.position;
        }

        initialBallPosition = ball.transform.position;
        ballRigidbody = ball.GetComponent<Rigidbody>();
    }

    public void ResetPositions()
    {
        // Destroy existing pins
        foreach (GameObject pin in pins)
        {
            Destroy(pin);
        }

        // Create new pins at the initial positions
        pins = new GameObject[initialPinPositions.Length];
        for (int i = 0; i < initialPinPositions.Length; i++)
        {
            pins[i] = Instantiate(pinPrefab, initialPinPositions[i], Quaternion.Euler(-90, 0, 0));
        }

        // Reset ball position and stop its movement
        ball.transform.position = initialBallPosition;
        ballRigidbody.velocity = Vector3.zero;
        ballRigidbody.angularVelocity = Vector3.zero;

        ballController.Reset();
    }
}