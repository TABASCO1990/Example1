using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCrash : MonoBehaviour
{
    public GameObject ball;
    private Rigidbody _ball;
    private void Awake()
    {
        _ball = ball.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Обьект вошел в триггер Столкновения");
        _ball.AddForce(new Vector3(0,0,100),ForceMode.Force);
    }
    
}
