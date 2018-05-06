using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float slowDownRate = 10f;

    public void EndGame()
    {
        StartCoroutine(ResetLevel());
    }

    private IEnumerator ResetLevel()
    {
        Time.timeScale = 1f / slowDownRate;
        Time.fixedDeltaTime =  Time.fixedDeltaTime / slowDownRate;

        yield return new WaitForSeconds(1f / slowDownRate);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownRate;

    }
}

/* TODO
 * 
 * Refactor ResetLevel to do the following:
 * Reset Player position
 * Return all blocks to pool
 * Reset all variables to default values
 * 
 */
