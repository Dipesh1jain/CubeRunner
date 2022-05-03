using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerscript;
    public Score score;
    public GameController gameController;
    public AudioSource audioSource1;
    public AudioSource audioSource;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            audioSource.Play();
            Destroy(other.gameObject);
            score.AddScore(1);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            audioSource1.Play();
            gameController.GameOver();
            playerscript.enabled = false;

        }
    }

}
