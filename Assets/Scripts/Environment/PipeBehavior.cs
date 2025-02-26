using UnityEngine;

// TODO
public class PipeBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 0.5f;

    // Update is called once per frame
    void Update()
    {
        // move the pipes left by moving the parent according to the velocity; make sure to multiply by Time.deltaTime
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if trigger touches GameObject with Player tag, increase score
    }
}
