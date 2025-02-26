using UnityEngine;

// TODO
public class BirdBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        // assign Rigidbody2D to _rb
    }

    // Update is called once per frame
    void Update()
    {
        // when the left button is pressed in this frame...
        // adjust the velocity of _rb by Vector3.up multiplied by _velocity
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // call GameOver from GameManager
    }
}
