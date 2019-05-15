using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HassyaDai : MonoBehaviour {
  public GameObject ball;
  Rigidbody rb;

  float x = 0;
  float y = 0;
  float z = 0;

  // Start is called before the first frame update
  void Start() {
    Invoke("hassya", 3f);
  }

  // Update is called once per frame
  void Update() {

  }

  void hassya() {
    GameObject ball_ = Instantiate(ball, this.gameObject.transform.position, transform.rotation);
    rb = ball_.GetComponent<Rigidbody>();
    x = Random.Range(-8f, -10f);
    z = Random.Range(-1f, 1f);
    Debug.Log(x + "," + z);
    Vector3 force = new Vector3(x * 0.01f, y * 0.01f, z * 0.01f);  // 力を設定
    rb.AddForce(force, ForceMode.Impulse);
    Invoke("hassya", 3f);
  }
}
