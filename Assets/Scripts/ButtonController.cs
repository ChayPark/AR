using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public BallController ballController;
    public string buttonFunction;

    public Material normalMaterial;
    public Material pressedMaterial;

    private MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            switch (buttonFunction)
            {
                case "Launch":
                    ballController.Launch();
                    meshRenderer.material = pressedMaterial;
                    break;
                case "Reset":
                    ballController.Reset();
                    meshRenderer.material = pressedMaterial;
                    break;
                case "Up":
                    ballController.IncreaseSpeed();
                    meshRenderer.material = pressedMaterial;
                    break;
                case "Down":
                    ballController.DecreaseSpeed();
                    meshRenderer.material = pressedMaterial;
                    break;
                case "Left":
                    ballController.MoveBall("Left");
                    meshRenderer.material = pressedMaterial;
                    break;
                case "Right":
                    ballController.MoveBall("Right");
                    meshRenderer.material = pressedMaterial;
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            meshRenderer.material = normalMaterial;
        }
    }
}
