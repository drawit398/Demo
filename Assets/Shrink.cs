using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrink : MonoBehaviour
{
    private Transform myTransform;
    private Vector3 velocity;

    public bool useLerp;
    public Vector3 target;
    public float smoothTime;
    public float lerpSpeed;
    // Use this for initialization
    void Start()
    {
        myTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (useLerp)
        {
            myTransform.localScale = Vector3.Lerp(myTransform.localScale, target, Time.deltaTime * lerpSpeed);
        }
        else
        {
            myTransform.localScale = Vector3.SmoothDamp(myTransform.localScale, target, ref velocity, smoothTime);
        }

    }
}
