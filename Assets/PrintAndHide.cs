using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;  // Public member variable
    private int i;
    private int randomValue;

    // Start is called before the first frame update
    void Start()
    {
        i = 0; // Initialize i to 0
        randomValue = Random.Range(150, 251); // Generates a random integer between 150 and 250 inclusive
    }

    // Update is called once per frame
    void Update()
    {
        // Increment i by 1 at the start of every frame
        i++;

        // Check for the Red tag condition
        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false); // Deactivate the game object
        }

        // Check for the Blue tag condition
        if (gameObject.CompareTag("Blue") && i == randomValue)
        {
            if (rend != null)
            {
                rend.enabled = false; // Disable the Renderer component
            }
        }
    }
}