using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleObjectButton : MonoBehaviour
{
    public GameObject objectToToggle;
    public GameObject onButton;
    public GameObject offButton;
    private MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = objectToToggle.GetComponent<MeshRenderer>();
        onButton.SetActive(true);
        offButton.SetActive(false);
    }

    public void ToggleObjectOn()
    {
        objectToToggle.SetActive(true);
        onButton.SetActive(false);
        offButton.SetActive(true);
    }

    public void ToggleObjectOff()
    {
        objectToToggle.SetActive(false);
        onButton.SetActive(true);
        offButton.SetActive(false);
    }
}
