using UnityEngine;

public class Pipe : MonoBehaviour
{
    public float movement;
    public float deadZone = -16;
    //public Rigidbody2D mybody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = transform.position + (Vector3.left * movement)*Time.deltaTime;
        Physics2D.SyncTransforms();
        if(transform.position.x<deadZone)
        {
            Destroy(gameObject);
        }  
    }
}
