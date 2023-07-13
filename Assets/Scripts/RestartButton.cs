using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public GameObject pin1;
    public GameObject pin2;
    public GameObject pin3;
    public GameObject pin4;
    public GameObject pin5;
    public GameObject pin6;
    public GameObject pin7;
    public GameObject pin8;
    public GameObject pin9;
    public GameObject pin10;

    public GameObject ball;

    public Vector3 initialPin1Position;
    public Vector3 initialPin2Position;
    public Vector3 initialPin3Position;
    public Vector3 initialPin4Position;
    public Vector3 initialPin5Position;
    public Vector3 initialPin6Position;
    public Vector3 initialPin7Position;
    public Vector3 initialPin8Position;
    public Vector3 initialPin9Position;
    public Vector3 initialPin10Position;

    public Vector3 initialBallPosition;

    private void Start()
    {
        // Save initial positions
        initialPin1Position = pin1.transform.position;
        initialPin2Position = pin2.transform.position;
        initialPin3Position = pin3.transform.position;
        initialPin4Position = pin4.transform.position;
        initialPin5Position = pin5.transform.position;
        initialPin6Position = pin6.transform.position;
        initialPin7Position = pin7.transform.position;
        initialPin8Position = pin8.transform.position;
        initialPin9Position = pin9.transform.position;
        initialPin10Position = pin10.transform.position;

        initialBallPosition = ball.transform.position;
    }

    public void ResetPositions()
    {
        // Reset pin positions
        pin1.transform.position = initialPin1Position;
        pin2.transform.position = initialPin2Position;
        pin3.transform.position = initialPin3Position;
        pin4.transform.position = initialPin4Position;
        pin5.transform.position = initialPin5Position;
        pin6.transform.position = initialPin6Position;
        pin7.transform.position = initialPin7Position;
        pin8.transform.position = initialPin8Position;
        pin9.transform.position = initialPin9Position;
        pin10.transform.position = initialPin10Position;

        // Reset ball position
        ball.transform.position = initialBallPosition;
    }
}