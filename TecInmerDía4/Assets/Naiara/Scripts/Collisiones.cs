using UnityEngine;

public class Collisiones : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision" + collision.gameObject.name);
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger" + other.gameObject.name);
    }
}
