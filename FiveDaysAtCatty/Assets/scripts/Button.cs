using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Vector3 firstpos;
    void Start()
    {
        firstpos = transform.localPosition;
    }

    public virtual void OnMouseDown()
    {
        transform.localPosition = firstpos - transform.right * 0.1f;
    }

    public virtual void OnMouseUp()
    {
        transform.localPosition = firstpos;
    }
}
