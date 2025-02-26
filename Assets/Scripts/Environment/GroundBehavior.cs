using UnityEngine;

// DONE
public class GroundBehavior : MonoBehaviour
{
    [SerializeField] private float _velocity = 0.1f;
    [SerializeField] private float _width = 5f;

    private SpriteRenderer _spriteRenderer;

    private Vector2 _startSize;

    // Start is called before the first frame update
    void Start()
    {
       _spriteRenderer = GetComponent<SpriteRenderer>();

       _startSize = new Vector2(_spriteRenderer.size.x, _spriteRenderer.size.y); 
    }

    // Update is called once per frame
    void Update()
    {
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + _velocity * Time.deltaTime, _spriteRenderer.size.y);
    
        if (_spriteRenderer.size.x > _width)
        {
            _spriteRenderer.size = _startSize;
        }
    }
}
