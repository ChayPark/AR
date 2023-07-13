using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleScript : MonoBehaviour
{
    public XRBaseInteractable interactableToToggle;

    private void Start()
    {
        if (interactableToToggle != null)
        {
            interactableToToggle.enabled = false;
        }
    }

    public void ToggleOn()
    {
        if (interactableToToggle != null)
        {
            interactableToToggle.enabled = true;
        }
    }

    public void ToggleOff()
    {
        if (interactableToToggle != null)
        {
            interactableToToggle.enabled = false;
        }
    }
}