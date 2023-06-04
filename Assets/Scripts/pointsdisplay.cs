using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class pointsdisplay : MonoBehaviour
{

    public Text scoreUI;
    void Update()
    {
        scoreUI.text = pointsControl.points.ToString();
    }
}

