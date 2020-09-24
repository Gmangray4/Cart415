using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;
using System.Diagnostics;


public class Fade_In_Out : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform img;
    [SerializeField] private Transform respawnPoint;

    void OnMouseDown()
    {
        Debug.Log("Click");
        img.transform.position = respawnPoint.transform.position;
    }

 
}
