using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Vector3 open;
    public Vector3 close;
    private Vector3 objectRotation;
    private float rotationSpeed = 3f;
    bool isOpen = true;
    int currentEffect = 0;

    public void Effect()
    {
        currentEffect = isOpen ? 2 : 1;
        isOpen = !isOpen;
    }

    void Update()
    {
        if (currentEffect != 0)
        {
            Vector3 toPosition = (currentEffect == 1) ? open : close;
            if (Vector3.Distance(transform.localPosition, toPosition) < 0.01f)
            {
                transform.localPosition = toPosition;
                //transform.rotation = Quaternion.Euler(270, 0, 0 + rotationSpeed);
                currentEffect = 0;
            }
            else
            {
                transform.localPosition = Vector3.Lerp(transform.localPosition, toPosition, 8f * Time.deltaTime);
                //transform.rotation = Quaternion.Euler(90, 0, 90 + 8f * Time.deltaTime);
            }
        }
        
    }
}
