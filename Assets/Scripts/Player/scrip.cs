// The sprite will fall under its weight.  After a short time the
// sprite will start its upwards travel due to the thrust force that is added
// in the opposite direction


using UnityEngine;
using System.Collections;

public class scrip : MonoBehaviour
{
    public Rigidbody2D rb;
    private float thrust = 10000.0f;
    Vector3 original;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.position = new Vector3(1266f, 966f, 0.0f);
        original = transform.position;
        Debug.Log(transform.position.y);
    }
    
    void Update()
    {
        if (transform.position.y > 966f & transform.position.y < 1000f){

        }
        if (transform.position.y > 966f & transform.position.y < 1499 ){
            rb.gravityScale = 3;
            
        }
        if (transform.position.y > 1499 & transform.position.y < 2499){
            rb.gravityScale = 9;
            
        }
        if (transform.position.y > 2499 ){
            rb.gravityScale = 91;
        }

    }

    void FixedUpdate()
    {
        
        if (transform.position.y < 966f){
            
            rb.gravityScale = 0;
            transform.position = new Vector3(1266f, 966f, 0.0f);
        }
        
    }
    public void applyForce(){
        
        rb.AddForce(transform.up * thrust);
        
        MonoBehaviour.print(rb.gravityScale);
    }

    public bool onMoon(){
        Debug.Log(transform.position.y);
        if (transform.position.y >= 965f){
            return true;
        }
        else{
            return false;
        }
    }
}