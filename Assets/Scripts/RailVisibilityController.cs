using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RailVisibilityController : MonoBehaviour
{
    public GameObject[] rails;
    private bool areRailsVisible = true;
    void Start()
    {
        // Initialize the rails array with all child GameObjects
        int childCount = transform.childCount;
        rails = new GameObject[childCount];

        for (int i = 0; i < childCount; i++)
        {
            rails[i] = transform.GetChild(i).gameObject;
        }
    }

    public void ToggleRails()
    {
        areRailsVisible = !areRailsVisible;

        foreach (GameObject rail in rails)
        {
            Renderer renderer = rail.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = areRailsVisible;
            }
        }
    }
}
