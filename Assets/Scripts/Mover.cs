using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed;
    private Rigidbody rig;
    // Start is called before the first frame update
    void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Start()
    {
        rig.velocity = transform.forward * speed;
    }
}
