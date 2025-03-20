using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 velocity, spin;
    void Start()
    {
        rb = GetComponent<Rigidbody>();    
    }

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // kick the ball like Roberto Carlos
            Kick();
        //apply magnus effect
        }
        ApplyMagnusEffect();
    }

    void Kick()
    {
        rb.linearVelocity = velocity; // kick forward
        rb.angularVelocity = spin; // kick spin Roberto carlos style
    }//End Method Kick    

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity , rb.angularVelocity);
        rb.AddForce(magnusForce, ForceMode.Force);   
    }// end Method ApplyMagnusEffect
}// End MagnusEffect
