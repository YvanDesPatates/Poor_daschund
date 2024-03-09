using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class BombObstacleScript : MonoBehaviour
{
    public Rigidbody bombRb;
    public Light spotLight;
    public float secondsBeforeBombFalls = 3;
    public float minimalSpotAngle = 10;

        
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(BeforeThrowBomb());
        StartCoroutine(ThrowBomb());
    }

    private IEnumerator BeforeThrowBomb()
    {
        float stepsDuration = secondsBeforeBombFalls / 3;
        float actualSpotAngle = spotLight.spotAngle;
        float spotAngleReduction = (actualSpotAngle - minimalSpotAngle) / 3;
        for (int i = 0; i < 3; i++)
        {
            yield return new WaitForSeconds(stepsDuration);
            actualSpotAngle -= spotAngleReduction;
            spotLight.spotAngle = actualSpotAngle;
        }
        spotLight.color = Color.red;
    }
    
    private IEnumerator ThrowBomb()
    {
        yield return new WaitForSeconds(secondsBeforeBombFalls);
        bombRb.isKinematic = false;
    }
}
