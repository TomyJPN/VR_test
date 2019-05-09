using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//参考：https://qiita.com/ashtkn/items/16c0adcbf1ba15dcc7c9
public class RacketFaceFollower : MonoBehaviour
{
  [SerializeField]
  float sensitivity = 50f;

  private Rigidbody rb;
  private GameObject target;
  private Vector3 velocity;

  void Awake() {
    rb = GetComponent<Rigidbody>();
  }

  public void SetTarget(GameObject target) {
    this.target = target;
  }

  void FixedUpdate() {
    if (target != null) {
      velocity = (target.transform.position - rb.transform.position) * sensitivity;
      rb.velocity = velocity;
      rb.transform.rotation = transform.rotation;
      transform.rotation = target.transform.rotation;
    }
  }
}
