using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [Header("Player Movement Script")]
    public PlayerMovement player;
    //? OnCollisionEnter() => akan dijalankan setiap kali player menabrak sesuatu
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            player.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
        // Debug.Log("we hit something.");
    }
}
