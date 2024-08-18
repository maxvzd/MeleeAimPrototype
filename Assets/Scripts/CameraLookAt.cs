using UnityEngine;

public class CameraLookAt : MonoBehaviour
{
    [SerializeField] private Transform transformToLookAt; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(transformToLookAt);
    }
}
