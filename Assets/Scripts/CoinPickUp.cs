using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    [SerializeField] AudioClip coinPickUpSfx;
    [SerializeField] int pointsForCoinPickUp = 100;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        FindObjectOfType<GameSession>().AddToScore(pointsForCoinPickUp);
        AudioSource.PlayClipAtPoint(coinPickUpSfx, Camera.main.transform.position);
        Destroy(gameObject);
    }
}
