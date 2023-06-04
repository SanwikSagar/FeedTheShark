using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointsControl : MonoBehaviour
{

    public static int points = 0;
    public void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("Fish"))
        {
            Destroy(coll.gameObject);

            points++;
        }
    }
}
