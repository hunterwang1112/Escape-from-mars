﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int reachRange = 100;

    CodeLock codeLock;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckHitObj();
        }
    }
    void CheckHitObj()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, reachRange))
        {
            codeLock = hit.transform.gameObject.GetComponentInParent<CodeLock>();
            if (codeLock != null)
            {
                string value = hit.transform.name;
                codeLock.SetValue(value);
            }
        }
    }
}
