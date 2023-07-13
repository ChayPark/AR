using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LaunchUIController : MonoBehaviour
{
    public BallController ballController;

    public TMP_Text speedText;
    public Button increaseSpeedButton;
    public Button decreaseSpeedButton;
    public Button launchButton;
    public Button moveRightButton;
    public Button moveLeftButton;

    private void Start()
    {
        // Assign listeners for the buttons
        increaseSpeedButton.onClick.AddListener(ballController.IncreaseSpeed);
        decreaseSpeedButton.onClick.AddListener(ballController.DecreaseSpeed);
        launchButton.onClick.AddListener(ballController.Launch);
        moveRightButton.onClick.AddListener(() => ballController.MoveBall("Right"));
        moveLeftButton.onClick.AddListener(() => ballController.MoveBall("Left"));
    }

    private void Update()
    {
        // Update the speed text
        speedText.text = ballController.speed.ToString();
    }
}
