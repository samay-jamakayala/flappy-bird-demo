using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehavior : MonoBehaviour
{
    public float velocity = 0.1f; // Speed of the ground movement
    public float width = 5f;     // Width of the ground object

    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position; // Store the initial position of the ground
    }

    // Update is called once per frame
    void Update()
    {
        // Move the ground to the left
        transform.Translate(Vector3.left * velocity * Time.deltaTime);

        // Check if the ground has moved past its width and reset its position
        if (transform.position.x < startPosition.x - width)
        {
            transform.position = startPosition;
        }
    }
}
