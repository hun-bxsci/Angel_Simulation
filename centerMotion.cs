using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class centerMotion : MonoBehaviour
{
    Quaternion start;
    Quaternion end;
    float timeCount = 0.0f;
    [SerializeField]
    float x,y,z,speed;
    void Start(){
        start = Quaternion.Euler(-x,-y,-z);
        end = Quaternion.Euler(x,y,z);
    }
    void Update()
    {
        transform.rotation = Quaternion.Slerp(start, end , timeCount);
        timeCount = Mathf.PingPong(Time.fixedTime/speed,1);
        
    }
}