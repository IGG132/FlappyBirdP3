using UnityEngine;

public class SPawner : MonoBehaviour
{
    public GameObject Pipe;
    public float Rate =2;
    private float timer =0;
    public float offset;
    void SpawnPipe(){
        float Lowest = transform.position.y - offset;
        float Hihhest = transform.position.y +(float)1.5*offset;

          Instantiate(Pipe,new Vector3(transform.position.x,Random.Range(Lowest,Hihhest),0),transform.rotation);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<Rate)
        {
            timer+=Time.deltaTime;
        }
        else
        {
             SpawnPipe();
             timer =0;
        }
    }
    
}
