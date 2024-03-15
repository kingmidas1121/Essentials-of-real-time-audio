using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleAndPositionChange : MonoBehaviour
{
    public Vector3 scaleChange;
    public Vector3 positionChange;
    public string myMessage;
    void Start()
    {
       Debug.Log(myMessage);
    }

    void Update()
    {
        transform.localScale += scaleChange;
        transform.position += positionChange;
    }
}
