using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookBehaviour : MonoBehaviour
{
    
    private float _rotationY = 0.0f;
    private float _rotationX = 0.0f;
    
    [SerializeField] private float maxVerticalAngle;
    [SerializeField] private float maxHorizontalAngle;
    [SerializeField] private float sensitivity = 1f;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _rotationY += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        _rotationX += Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        _rotationX = Mathf.Clamp(_rotationX, -maxVerticalAngle, maxVerticalAngle);
        _rotationY = Mathf.Clamp(_rotationY, -maxHorizontalAngle, maxHorizontalAngle);
        
        transform.eulerAngles = new Vector3(-_rotationX, _rotationY, 0);

    }
}
