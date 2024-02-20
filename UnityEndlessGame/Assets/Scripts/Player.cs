using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;

    float width;
    float height;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        width = (float)Screen.width / 4f;
        //height = (float)Screen.height / 5f;
    }

    // Update is called once per frame
    void Update()
    {
        // Automatically move the player forward
        rb.AddForce(Vector3.forward * speed * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Vector2 pos = touch.position;
                pos.x = (pos.x - width) / width;
                //pos.y = (pos.y - height) / height;

                // Déplacement uniquement sur l'axe x
                Vector3 vec = new Vector3(pos.x, transform.position.y, transform.position.z);
                transform.position = vec;
            }
        }
    }
}
