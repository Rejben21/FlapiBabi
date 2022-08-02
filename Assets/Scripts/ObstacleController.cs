using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(-2, 0) * Time.deltaTime);

        if(transform.position.x <= -11)
        {
            Destroy(this.gameObject);
        }
    }
}
