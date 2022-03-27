using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour {
    private int randomValue;
    private int tempRandomValue;
    public List<GameObject> obstacles;
    private void Start() {
        //foreach (var obstacle in obstacles) obstacle.SetActive(false);
        randomValue = Random.Range(0, obstacles.Count);
        obstacles[randomValue].SetActive(true);
    }
    public void ChangeTheObstacles() {
        obstacles[randomValue].SetActive(false);
        while (true) {
            tempRandomValue = Random.Range(0, obstacles.Count);
            if (tempRandomValue != randomValue) {
                randomValue = tempRandomValue;
                break;
            }
        }
        obstacles[randomValue].SetActive(true);
    }
}