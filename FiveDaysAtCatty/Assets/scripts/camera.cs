using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touches.Length > 0)
        {
            Touch touch = Input.touches[0];
            if (touch.phase == TouchPhase.Moved) transform.Rotate(0f, touch.deltaPosition.x, 0f);
        }
    }

    
}
