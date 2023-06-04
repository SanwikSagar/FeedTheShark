using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lifedisplay : MonoBehaviour
{
    public Text scoreUI;
    void Update()
    {
        scoreUI.text = health.life.ToString();
    }
}
