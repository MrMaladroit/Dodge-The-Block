using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private float slowDownRate = 10f;
    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    private IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowDownRate;
        Time.fixedDeltaTime =  Time.fixedDeltaTime / slowDownRate;

        yield return new WaitForSeconds(1f / slowDownRate);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowDownRate;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
