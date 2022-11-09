using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchJump : MonoBehaviour
{
    
    public GameObject jumpCollider;
    public bool turningOn;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            jumpCollider.GetComponent<BoxCollider2D>().enabled = turningOn;
            jumpCollider.GetComponent<SpriteRenderer>().enabled = turningOn;
        }
    }
}