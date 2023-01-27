using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;


    void OnCollisionEnter (Collision collisionInfo){
        if (collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;//if you hit a Obstacle tag object, then movement will be disabled

            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
