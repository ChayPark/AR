using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public BallController ball;

    public void OnKeyPress(string key)
    {
        switch (key)
        {
            case "Launch":
                ball.Launch();
                break;
            case "Reset":
                ball.Reset();
                break;
            default:
                float number;
                if (float.TryParse(key, out number))
                {
                    ball.AdjustWeight(number);
                }
                break;
        }
    }

    public void OnArrowPress(string arrow)
    {
        switch (arrow)
        {
            case "Up":
                ball.AdjustSpeed(ball.speed + 1);
                break;
            case "Down":
                ball.AdjustSpeed(ball.speed - 1);
                break;
            case "Left":
                ball.MoveBall("Left");
                break;
            case "Right":
                ball.MoveBall("Right");
                break;
        }
    }
}
