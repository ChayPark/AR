using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public string buttonFunction;
    public InputController inputController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            if (buttonFunction == "Launch" || buttonFunction == "Reset")
            {
                inputController.OnKeyPress(buttonFunction);
            }
            else if (buttonFunction == "Up" || buttonFunction == "Down" || buttonFunction == "Left" || buttonFunction == "Right")
            {
                inputController.OnArrowPress(buttonFunction);
            }
            else
            {
                float number;
                if (float.TryParse(buttonFunction, out number))
                {
                    inputController.ball.AdjustWeight(number);
                }
            }
        }
    }
}
