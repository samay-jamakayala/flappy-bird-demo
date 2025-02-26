using TMPro;
using UnityEngine;

// TODO
public class ScoreManager : MonoBehaviour
{
    public static ScoreManager ScoreManagerInstance;

    [SerializeField] private TextMeshProUGUI _currentScoreText;

    private int _score;

    // Start is called before the first frame update
    void Awake()
    {
        if (ScoreManagerInstance)
        {
            ScoreManagerInstance = this;
        }
    }

    void Start()
    {
        // set the text of _currentScoreText to _score
    }

    public void IncreaseScore()
    {
        // increment _score

        // update the text of _currentScoreText to new _score
    }
}
