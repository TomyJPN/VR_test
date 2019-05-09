using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
  [SerializeField]
  GameObject target;  //返球する位置となるtarget

  public int correction=2;
  public int correction_Y = 4;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {

  }

  private void OnTriggerEnter(Collider other) {
    if (other.tag == "ball") {
      Debug.Log("ボールイン");
      Rigidbody rb = other.GetComponent<Rigidbody>();
      rb.velocity = Vector3.zero;

      Vector3 vec=target.transform.position-other.transform.position;  //ボールからターゲットへのベクトル
      vec = vec.normalized * correction;
      vec.y = correction_Y;
      //vec.y = target.transform.position.y - other.transform.position.y;

      rb.velocity = vec;
    }
  }
}
