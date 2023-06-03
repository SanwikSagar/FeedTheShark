//using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using UnityEngine;
using static System.Random;
public class Fish : MonoBehaviour
{
    void Start()
    {
     
    }
    private float speed = 0.8f;
    // Start is called before the first frame update
    //ivate float rand;
    //int x = Random.Range(-9, 11);
    //int y = 3;
    //int z = Random.Range(-5, 15);
    //private UnityEngine.Vector3 target = new UnityEngine.Vector3(0, -1, 20);
    //private Vector3 target = new Vector3(x,y,z);//new Vector3(Random.Range(-9, 11), 3, Random.Range(-5, 15));
    //private Vector3 target =  position;
    // Update is called once per frame
    void Update()
    {
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-9f, 12f), 1.5f, Random.Range(-5f, 16f));
        transform.position = Vector3.MoveTowards(transform.position, randomSpawnPosition, Time.deltaTime * speed);
        //int x = Random.Range(-9, 11);
        //int y = 3;
        //int z = Random.Range(-5, 15);
        //private Vector3 target = new Vector3(0, 3, 0);
        //transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
}

