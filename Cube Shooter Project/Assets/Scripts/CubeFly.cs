using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFly : MonoBehaviour
{
    Rigidbody rb;
    public float FlySpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.Find("Cube").gameObject.GetComponent<Rigidbody>();
        rb.AddForce(new Vector3(Random.Range(-0.2f, 0.2f), Random.Range(0.4f, 0.6f), -Random.Range(1f, 1.2f)) * FlySpeed, ForceMode.Impulse);
    }
}
