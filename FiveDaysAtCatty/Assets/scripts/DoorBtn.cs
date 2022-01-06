using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBtn : Button
{
    public Door door;
    void OnMouseUpAsButton()
    {
        OnMouseDown();
        Invoke("OnMouseUp", .1f);
        door.Open();
    }
}
