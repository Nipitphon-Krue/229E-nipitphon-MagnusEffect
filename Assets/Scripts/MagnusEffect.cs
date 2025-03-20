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
            //kick
            Kick();
            //apply magnus effect
            ApplyMagnusEffect();
        }
    }
    void Kick() 
    { 
        rb.linearVelocity = velocity; //เดะตรงไปหน้า
        rb.angularVelocity = spin; //แรงหมุ่น
    }

    void ApplyMagnusEffect()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity , rb.angularVelocity);

        rb.AddForce(magnusForce, ForceMode.Force);
    }
}
