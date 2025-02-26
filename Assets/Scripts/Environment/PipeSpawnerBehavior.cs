using UnityEngine;

// DONE
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
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        // call SpawnPipe every time _maxTime is reached according to _timer
        if (_timer >_maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }

        // increment _timer by Time.deltaTime
        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        // set spawnPosition based on Random.Range of possible height
        Vector2 spawnPosition = transform.position + new Vector3(1.5f, Random.Range(-_heightRange, _heightRange));
        // instantiate Pipe prefab at that spawnPosition
        GameObject pipe = Instantiate(_pipe, spawnPosition, Quaternion.identity);
    
        // destroy itself after 10 seconds
        Destroy(pipe, 10f);
    }
}
