using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton yapýsý

    [SerializeField] private GameObject gameOverPanel; // Game Over ekraný (UI)
    [SerializeField] private Text scoreText;

    private float score;

    private void Awake()
    {

        if (instance == null)
        {
            instance = this;
        }
        // Oyun baþladýðýnda zaman akýþýný normalleþtir (Restart atýnca 0 kalmasýn diye)
        Time.timeScale = 1f;
    }

    private void Update()
    {
        ScoreTracker();
    }

    public void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void RestartGame()
    {
        // Þu anki sahneyi baþtan yükle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ScoreTracker()
    {
        score += Time.deltaTime * 10;
        scoreText.text = "Score : " + (int)score; 
    }
}
