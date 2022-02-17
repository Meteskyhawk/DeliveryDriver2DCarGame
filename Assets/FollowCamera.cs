using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField] GameObject thingToFollow;

    // Update is called once per frame
    void LateUpdate()
    {
      transform.position = thingToFollow.transform.position + new Vector3 (-7.7f, -41.9f,-10f);
    }
}
