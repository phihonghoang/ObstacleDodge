using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Collider for both objects are necessary
    // Moving object has to have a Rigidbody
    private void OnCollisionEnter(Collision other) 
    {
        
        if (other.gameObject.tag == "Player")
        {
            // Provides access to specific components of the GameObject
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
        
    }
}
