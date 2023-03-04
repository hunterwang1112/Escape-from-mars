using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    void Start()
    {
        Physics.gravity = new Vector3(0, -3.711f, 0);
    }
    void Update()
    {
        Physics.gravity = new Vector3(0, -3.711f, 0);
    }
}