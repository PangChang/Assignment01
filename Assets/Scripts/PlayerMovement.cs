using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
 
    
    public float forwardForce;
    public Slider slider;
    public static float Speed;

    public float sidewayForce = 500f;


    void FixedUpdate()
    {
        // Add a forward force
        forwardForce = DataManager.Speed ;

        rb.AddForce(0, 0, forwardForce  * Time.deltaTime); // * Time.deltaTime is to help with the frames.
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); //Allows the button in the input "d" to move a certain direction, with force applied
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);//Allows the button in the input "a" to move a certain direction, with force applied
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
