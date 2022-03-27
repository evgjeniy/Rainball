using UnityEngine;

public class EndOfZone : MonoBehaviour
{
    public Transform player;
    private Vector3 startPosition;
    private void OnTriggerEnter(Collider other)
    {
        startPosition = player.position;
        startPosition.z = 0;
        player.position = startPosition;
        FindObjectOfType<ObstacleManager>().ChangeTheObstacles();
        FindObjectOfType<Score>().amount += (int)transform.position.z;
    }
}