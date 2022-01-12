using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float rotationSpeed;

    public int addToScore;

    void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other) 
    {
         if(other.CompareTag("Player"))
        {
            other.GetComponent<Player>().AddScore(addToScore);
            Destroy(gameObject);
        }
    }
}
