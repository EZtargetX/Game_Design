using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEnemySpawner : MonoBehaviour
{
    public GameObject tEnemyPrefab;
    private float counter = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        while (counter > 0)
        {
            counter -= 1;
            Instantiate(tEnemyPrefab, transform.position, transform.rotation);
        }
    }
}
