using TMPro;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameOverCanvas;
    public int superCollectibleValue = 3;

    private int _score = 0;
    
    public void PlayerPickedUpCollectible()
    {
        _score++;
        scoreText.text = _score.ToString();
    }
    public void PlayerPickedUpSuperCollectible()
    {
        _score += superCollectibleValue;
        scoreText.text = _score.ToString();
    }
    
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
    }
}
