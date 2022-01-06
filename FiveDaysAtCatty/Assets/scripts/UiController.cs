using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public GameObject currentCamera;
    public GameObject screen;
    public GameObject[] cameras;

    private int cameraId = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openPlanshet()
    {
        if (screen.activeSelf)
        {
            screen.SetActive(false);
            cameras[cameraId].SetActive(false);
            currentCamera.SetActive(true);
        }
        else
        {
            screen.SetActive(true);
            cameras[cameraId].SetActive(true);
            currentCamera.SetActive(false);
        }
    }

    public void changeCamera(int id)
    {
        cameras[cameraId].SetActive(false);
        cameraId = id;
        cameras[cameraId].SetActive(true);
    }
}
