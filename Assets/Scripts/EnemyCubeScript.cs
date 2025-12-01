using UnityEngine;

public class EnemyCubeScript : MonoBehaviour
{
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float xvel, yvel, zvel;

        xvel = rb.linearVelocity.x;
        yvel = rb.linearVelocity.y;
        zvel = rb.linearVelocity.z;

        rb.linearVelocity = new Vector3(xvel, yvel,zvel);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.gameObject.tag == "Player" )
        {
            FindFirstObjectByType<AudioManager>().Play("Hit");
            print("Collided with the player");
            LevelManager.instance.playerhp -= 10;
        }
    }
}
