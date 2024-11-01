using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{
    public Camera Camera1;
    public Camera Camera2;
    public Camera Camera3;
    public Camera Camera4;

    bool _enabled = true;

    // Start is called before the first frame update
    void Start()
    {
        SetActiveCamera(Camera1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetActiveCamera(Camera1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetActiveCamera(Camera2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetActiveCamera(Camera3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SetActiveCamera(Camera4);
        }

    }
    void SetActiveCamera(Camera activeCamera)
    {
        Camera1.enabled = (activeCamera == Camera1);
        Camera2.enabled = (activeCamera == Camera2);
        Camera3.enabled = (activeCamera == Camera3);
        Camera4.enabled = (activeCamera == Camera4);
    }
}
