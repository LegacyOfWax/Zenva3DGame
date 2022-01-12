using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offSet;

    void Update()
    {
        transform.position = target.position +offSet;   
    }
}
