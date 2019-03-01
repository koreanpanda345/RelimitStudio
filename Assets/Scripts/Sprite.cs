using UnityEngine;
public class Sprite : MonoBehaviour
{
  //the animator Method is going to be used to mess with sprite sheets
    private Animator animator;
  
    // Use this for initialization
    void Start()
    {
    //This is calling on the Animator component on the object
        animator = this.GetComponent<Animator>();
    }
 
    // Update is called once per frame
    void Update()
    {
        //Input to move
        var vertical = Input.GetAxis("Vertical");
        var horizontal = Input.GetAxis("Horizontal");
        //This is going to start the sprite sheet animation that will be used.
        if (vertical > 0)
        {
            animator.SetInteger("Direction", 2);
        }
        else if (vertical < 0)
        {
            animator.SetInteger("Direction", 0);
        }
        else if (horizontal > 0)
        {
            animator.SetInteger("Direction", 1);
        }
        else if (horizontal < 0)
        {
            animator.SetInteger("Direction", 3);
        }
    }
}
