using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{

    [SerializeField] float speed = 1f;
    // reference to a different gameObject
    [SerializeField] Transform player;
    Vector3 playerPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // exact position of the gameObject, value doesn't change
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer()
    {
        // current - position to move from
        // target - position to move towards
        // maxDistanceDelta - distance to move each time 
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, speed * Time.deltaTime);
    }

    void DestroyWhenReached() 
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }
    }
}
