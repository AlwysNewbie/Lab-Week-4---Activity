using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;   // Public game object member variables
    [SerializeField]
    private GameObject blueObj; // Private game object member variable, but visible in inspector view

    private int i;

    // Start is called before the first frame update
    void Start()
    {
        // Limit the framerate to 60
        Application.targetFrameRate = 60;

        // Create a redObj at (2,0,0) with a rotation of zero
        Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);

        // Create a blueObj at (-2,0,0) with a rotation of zero
        Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);

        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // Increment i by 1 at the start of every frame
        i++;

        // Print the desired message to the console
        Debug.Log(gameObject.name + ":" + i);
    }
}
