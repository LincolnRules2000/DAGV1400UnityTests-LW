using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger("DoubleJump");
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            animator.SetTrigger("Hit");
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fall");
        }

        if (Input.GetAxis("Horizontal") != 0)
        {
            animator.SetTrigger("Run");
        }
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("WallJump");
        }
        
        else
        {
            animator.SetTrigger("Idle");
        } 
    }
}
