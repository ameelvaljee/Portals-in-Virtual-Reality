using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRising : MonoBehaviour
{
    public float speed =0.005f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate( Vector3.up * Time.deltaTime * speed );
    }
}
