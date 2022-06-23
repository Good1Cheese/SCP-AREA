using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    void Update()
    {
        Vector3 mov = new Vector3(4 + Mathf.Sin(1 * Time.time) * 2, transform.position.y, transform.position.z);
        transform.position = mov;
    }
}
