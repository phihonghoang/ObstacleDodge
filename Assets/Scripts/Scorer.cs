using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int hits = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.tag != "Hit")
        {
            Debug.Log("You've bumped into a thing this many times: " + hits++);
        }
    }
}
