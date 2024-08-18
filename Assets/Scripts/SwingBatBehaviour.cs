using UnityEngine;

public class SwingBat : MonoBehaviour
{
    private Animator _animator;
    
    private static readonly int IsLeftButtonDown = Animator.StringToHash("IsLeftMouseDown");

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animator.SetBool(IsLeftButtonDown, true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool(IsLeftButtonDown, false);
        }
    }
}
