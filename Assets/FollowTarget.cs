using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform targetToFollow;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = targetToFollow.position;
    }
}
