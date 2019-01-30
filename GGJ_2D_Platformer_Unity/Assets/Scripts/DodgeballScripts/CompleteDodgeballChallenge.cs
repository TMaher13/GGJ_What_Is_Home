using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteDodgeballChallenge : MonoBehaviour
{

    private PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "Player") {
          if(player.progress < 2)
            player.progress++; // update player progress
        }
    }
}
