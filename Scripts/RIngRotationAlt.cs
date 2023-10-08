using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotationAlt : MonoBehaviour
{   
    
    // [SerializeField]
    // GameObject center;
    
    public GameObject Center,ring;
    private float x,y;
    [SerializeField, Range(10,180)]
    float speed;
    void start(){
        x= ring.transform.position.x;
        y= ring.transform.position.y;
    }
    void Update(){
        ring.transform.RotateAround(Center.transform.position, new Vector3(x,y,0), speed*Time.deltaTime);
    }
}
