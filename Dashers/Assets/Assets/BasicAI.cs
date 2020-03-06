using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAI : MonoBehaviour
{
    public float speed = 5;
    public Transform target;
    public Transform myTransform;

    // Start is called before the first frame update
    void Start()
    {
        transform.LookAt(target);

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
