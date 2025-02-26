using UnityEngine;

// DONE
public class PipeBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 0.5f;

    private Transform pipe0;
    private Transform pipe1;

    void Start()
    {
        // assign the transforms of the child pipes
        pipe0 = transform.GetChild(0);
        pipe1 = transform.GetChild(0);  
    }

    // Update is called once per frame
    void Update()
    {
        // move the child pipes left after frame according to the velocity, make sure to multiply by Time.deltaTime
        pipe0.position += Vector3.left * _velocity * Time.deltaTime;
        pipe1.position += Vector3.left * _velocity * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if trigger touches GameObject with Player tag, increase score
        ScoreManager.ScoreManagerInstance.IncreaseScore();
    }
}
