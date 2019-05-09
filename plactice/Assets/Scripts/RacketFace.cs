using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//参考：https://qiita.com/ashtkn/items/16c0adcbf1ba15dcc7c9
public class RacketFace : MonoBehaviour
{
  [SerializeField]
  GameObject faceFollowerPrefab;

  private GameObject faceFollower;

  void OnEnable() {
    faceFollower = Instantiate(faceFollowerPrefab, transform.position, transform.rotation);
    faceFollower.GetComponent<RacketFaceFollower>().SetTarget(gameObject);
  }

  void OnDisable() {
    Destroy(faceFollower);
  }
}
