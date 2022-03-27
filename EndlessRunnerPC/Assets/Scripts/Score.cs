using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [HideInInspector]
    public int amount = 0;
    [HideInInspector]
    public int score = 0;
    public Transform player;
    private Text scoreText;
    private void Start() {
        scoreText = GetComponent<Text>();
    }
    void Update() {
        score = (int)player.position.z + amount;
        scoreText.text = score.ToString("0");
    }
}