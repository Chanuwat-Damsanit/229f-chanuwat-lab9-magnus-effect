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
        if (Input.GetKeyDown(KeyCode.K))
        {
            Kick();
        }
        ApplyMagnusEffect();
    }

    void Kick()
    {
       //แรงเตะตรงไปหา goal
       rb.linearVelocity = velocity;

       //แรงหมุนบอล
       rb.angularVelocity = spin;
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        rb.AddForce(magnusForce);
    }
}
