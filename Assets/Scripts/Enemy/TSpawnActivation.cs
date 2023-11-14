using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TSpawnActivation : MonoBehaviour
{
    public GameObject tSpawn;

    void Start()
    {
    //    tSpawn.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tSpawn.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            tSpawn.SetActive(false);
        }
    }

    // When this works. it should be activating the spawner once the player enters its collision

}
