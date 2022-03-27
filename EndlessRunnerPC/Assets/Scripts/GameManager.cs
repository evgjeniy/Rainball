using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    [Range(0.1f, 2f)]
    public float delayTime = 1f;
    private PlayerMovement playerMovement;
    private FollowToPlayer followScript;
    private Score scoreScript;
    public Text scoreText;
    public GameObject panel;
    private void Start() {
        playerMovement = FindObjectOfType<PlayerMovement>();
        followScript = FindObjectOfType<FollowToPlayer>();
        scoreScript = FindObjectOfType<Score>();
    }

    public void GameOver() {
        playerMovement.enabled = false;
        followScript.enabled = false;
        scoreScript.enabled = false;
        Invoke("TurnOnThePanel", delayTime);
        scoreText.text = "YOUR SCORE: " + scoreScript.score.ToString();
    }

    public void Reload() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void TurnOnThePanel() {
        panel.SetActive(true);
    }

    public void GoToMainMenu() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}