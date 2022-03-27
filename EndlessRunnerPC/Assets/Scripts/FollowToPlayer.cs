using UnityEngine;

public class FollowToPlayer : MonoBehaviour {
    public Transform player;

    void Update() {
        transform.position = player.position;
    }
}
