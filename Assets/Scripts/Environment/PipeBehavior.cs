using UnityEngine;

// TODO
public class PipeBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 0.5f;

    private Transform pipe0;
    private Transform pipe1;

    void Start()
    {
        // assign the transforms of the child pipes
    }

    // Update is called once per frame
    void Update()
    {
        // move the child pipes left after frame according to the velocity, make sure to multiply by Time.deltaTime
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if trigger touches GameObject with Player tag, increase score
    }
}
