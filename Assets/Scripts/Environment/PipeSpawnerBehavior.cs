using UnityEngine;

// TODO
public class PipeSpawnerBehavior : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _heightRange = 0.5f;
    [SerializeField] private GameObject _pipe;

    private float _timer;

    // Start is called before the first frame update
    void Start()
    {
        // call SpawnPipe
    }

    // Update is called once per frame
    void Update()
    {
        // call SpawnPipe every time _maxTime is reached according to _timer

        // increment _timer by Time.deltaTime
    }

    private void SpawnPipe()
    {
        // set spawnPosition based on Random.Range of possible height
        // instantiate Pipe prefab at that spawnPosition
    
        // destroy itself after 10 seconds
    }
}
