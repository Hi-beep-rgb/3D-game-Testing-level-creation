using Mono.Cecil.Cil;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        LevelManager.instance.SetHighScore(50);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.1f, 0);

        float xvel, yvel, zvel;

        xvel = rb.linearVelocity.x;
        yvel = rb.linearVelocity.y;
        zvel = rb.linearVelocity.z;

        if (Input.GetKey("d"))
        {
            xvel = 5;
        }

        if (Input.GetKey("a"))
        {
            xvel = -5;
        }

        if (Input.GetKey("w"))
        {
            zvel = 5;
        }

        if ( Input.GetKey("s"))
        {
            zvel = -5;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            yvel = 5;
        }

        rb.linearVelocity = new Vector3(xvel, yvel, zvel);

        if (LevelManager.instance.playerhp <= 0)
        {
            transform.position = new Vector3(555.81f, 0.769f, -16.2f);
        }
    }

    //debug text output
    private void OnGUI()
    {
        //read variable from LevelManager singleton
        int score = LevelManager.instance.GetHighScore();

        string text = "High score: " + score;

        /*text += "\nThis is more text";*/

        // define debug text area
        GUI.contentColor = Color.white;
        GUILayout.BeginArea(new Rect(10f, 10f, 1600f, 1600f));
        GUILayout.Label($"<size=24>{text}</size>");
        GUILayout.EndArea();
    }

}
