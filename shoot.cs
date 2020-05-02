using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0,1)*Time.deltaTime*5);
        if (transform.position.y > 40)
            Destroy(this.gameObject);
    }
}
