using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D body;
  public   float k=10;
  public LogicScript logic;
  private bool check = true;
  private float deadZone = -20;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        check = true;
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.Space) && check)
        {
            body.linearVelocityY = k;
            //body.linearVelocityX = k;
        };
        if(transform.position.y<deadZone || transform.position.y>-0.5*deadZone)
        {
             logic.gameOver();
             check = false;
        }
    }

 void OnCollisionEnter2D(Collision2D collision) 
 {
         Debug.Log("Hit: " + gameObject.name);
        logic.gameOver();
        check = false;
 }
}