using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] float timer;
    [SerializeField] float baseTimerValue;
    // Start is called before the first frame update
    void Start()
    {
        timer = baseTimerValue;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
    }

    public void SetTimer(float value)
    {
        timer = value;
    }
}


