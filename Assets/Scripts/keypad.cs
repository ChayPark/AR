using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class keypad : MonoBehaviour
{
    // Object to be enabled is the keypad.
    public TMP_InputField charHolder;
    public GameObject button0;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;
    public GameObject button9;
    public GameObject flo;
    public GameObject clear;
    public GameObject enter;
   
    public GameObject bowlingBall;

    public void b1()
    {
        charHolder.text = charHolder.text + "1";
    }
    public void b2()
    {
        charHolder.text = charHolder.text + "2";
    }
    public void b3()
    {
        charHolder.text = charHolder.text + "3";
    }
    public void b4()
    {
        charHolder.text = charHolder.text + "4";
    }
    public void b5()
    {
        charHolder.text = charHolder.text + "5";
    }
    public void b6()
    {
        charHolder.text = charHolder.text + "6";
    }
    public void b7()
    {
        charHolder.text = charHolder.text + "7";
    }
    public void b8()
    {
        charHolder.text = charHolder.text + "8";
    }
    public void b9()
    {
        charHolder.text = charHolder.text + "9";
    }
    public void b0()
    {
        charHolder.text = charHolder.text + "0";
    }
    public void bfloat()
    {
        charHolder.text = charHolder.text + ".";
    }
    public void clearEvent()
    {
        charHolder.text = null;
    }
    public void enterEvent()
    {
        // Check if the text can be parsed to a float
        if (float.TryParse(charHolder.text, out float weight))
        {
            // Change the mass of the bowlingBall object
            bowlingBall.GetComponent<Rigidbody>().mass = weight;
            Debug.Log("Weight set to " + weight.ToString() + " kg");
        }
        else
        {
            Debug.Log("Invalid input. Please enter a valid number for the weight.");
        }
    }
}