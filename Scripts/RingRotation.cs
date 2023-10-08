using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotation : MonoBehaviour
{   
    
    [SerializeField]
    Transform ring;
    
    [SerializeField, Range(10,180)]
    float degrees;

    void Update(){
        ring.transform.Rotate(new Vector3(0, degrees ,0)* Time.deltaTime);
    }
}
