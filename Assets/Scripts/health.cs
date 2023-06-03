using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class health : MonoBehaviour
{
    public static int life = 3;
    void Start()
    {
        life = 3;
    }
    public int gamestatus = 0;
    public TextWriter textWriter;
    //public static int life = 3;
    public void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.CompareTag("life"))
        {
            Destroy(coll.gameObject);
            life--;
            if (life == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                //textWriter = new TextWriter("GameOver");
            }
        }
    }
}