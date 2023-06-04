
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Random;

public class SpawnObject : MonoBehaviour
{
    //public Transform[] spawnPoints;
    public GameObject[] Prefabs;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StarSpawning());
    }

    IEnumerator StarSpawning()
    {
        /* yield return new WaitForSeconds(1);
         Instantiate(Prefabs[0], spawnPoints[0].position, Quaternion.identity);

         yield return new WaitForSeconds(1);
         Instantiate(Prefabs[1], spawnPoints[0].position, Quaternion.identity);
        */
        yield return new WaitForSeconds(1);
        for (int i=0; i<2; i++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-8f, 8f), -3f, Random.Range(-16f, 16f));
            Instantiate(Prefabs[i], randomSpawnPosition, Quaternion.identity);
        }
        /*yield return new WaitForSeconds(1);
        Instantiate(ships[4], spawnPoints[4].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[0], spawnPoints[0].position, Quaternion.identity);

        yield return new WaitForSeconds(3);
        Instantiate(ships[1], spawnPoints[1].position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Instantiate(ships[3], spawnPoints[3].position, Quaternion.identity);

        yield return new WaitForSeconds(5);
        Instantiate(ships[2], spawnPoints[2].position, Quaternion.identity);

        */


       
        

        yield return new WaitForSeconds(1);
        StartCoroutine(StarSpawning());
    }
}