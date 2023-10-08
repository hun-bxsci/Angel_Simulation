using UnityEngine;

public class WingMotion : MonoBehaviour
{


  // Start is called before the first frame update
  [SerializeField, Range(1,20)]
  float magnitude;
  [SerializeField]
  GameObject center; 
  void Start()
  {
    magnitude = magnitude/100;

  }
  // Update is called once per frame

  void Update()
  {
    transform.Rotate(new Vector3(0,0,Mathf.Sin(Time.fixedTime)*magnitude));//rotation based on given magnitude

  }

}