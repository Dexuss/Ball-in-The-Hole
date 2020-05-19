using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleController : MonoBehaviour
{
    void Start()
    {
        this.transform.position = new Vector3(Random.Range(0.0f, 9.0f), transform.position.y, transform.position.z);
    }
}
