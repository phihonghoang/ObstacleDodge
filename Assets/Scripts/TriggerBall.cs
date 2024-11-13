using UnityEngine;

public class TriggerBall : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] GameObject ball1;
    [SerializeField] GameObject ball2;
    [SerializeField] GameObject ball3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
        {
            if (ball != null && ball1 != null && ball2 != null && ball3 != null)
            {
                ball.SetActive(true);
                ball1.SetActive(true);
                ball2.SetActive(true);
                ball3.SetActive(true);
            }
        }
    }
}
