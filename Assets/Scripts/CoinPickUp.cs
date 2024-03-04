using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    [SerializeField] AudioClip coinSfx;
    [SerializeField] int pointsPickUp = 100;

    bool wasCollected = false;

    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && !wasCollected)
        {
            FindObjectOfType<GameSession>().increaseScore(pointsPickUp);
            AudioSource.PlayClipAtPoint(coinSfx, Camera.main.transform.position);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
