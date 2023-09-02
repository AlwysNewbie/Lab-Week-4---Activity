using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;   // Public game object member variables
    [SerializeField]
    private GameObject blueObj; // Private game object member variable, but visible in inspector view

    private int i;  // Make i a member variable of the class
    private GameObject redInstance;  // Reference to the instantiated redObj
    private GameObject blueInstance; // Reference to the instantiated blueObj

    // Start is called before the first frame update
    void Start()
    {
        // Limit the framerate to 60
        Application.targetFrameRate = 60;

        // Create a redObj at (2,0,0) with a rotation of zero and store its reference
        redInstance = Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);

        // Create a blueObj at (-2,0,0) with a rotation of zero and store its reference
        blueInstance = Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);

        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // Increment i by 1 at the start of every frame
        i++;

        // Print the desired message to the console for both red and blue instances
        Debug.Log(redInstance.name + ":" + i);
        Debug.Log(blueInstance.name + ":" + i);
    }
}