using TMPro;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    private int _score = 0;
    
    public void IncrementScore()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
}