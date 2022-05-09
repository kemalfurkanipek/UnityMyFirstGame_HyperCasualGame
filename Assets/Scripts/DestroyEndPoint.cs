using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEndPoint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("destroy", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }

    void destroy()
    {
        if (gameObject.tag=="foodScore") { Destroy(gameObject); }
    }
}
