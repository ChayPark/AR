using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleScript : MonoBehaviour
{
    public MonoBehaviour scriptToToggle;

    public void ToggleOn()
    {
        if (scriptToToggle != null)
        {
            scriptToToggle.enabled = true;
        }
    }

    public void ToggleOff()
    {
        if (scriptToToggle != null)
        {
            scriptToToggle.enabled = false;
        }
    }
}
