using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Transform start;
    public Transform end;
    public float speed = 0.5f;

    [Range(0,1)]
    public float t = 0.0f;



    // Start is called before the first frame update
    void Start()
    {
        transform.position = start.position;
    }

    // Update is called once per frame
    void Update()
    {
        //t += speed * Time.deltaTime


        //t = Mathf.Clamp01(t);
        // Mathf.lerp

        t = Mathf.MoveTowards(t, 1.0f, speed * Time.deltaTime);
        transform.position = Vector3.Lerp(start.position, end.position, t );

        transform.rotation = Quaternion.Slerp(start.rotation, end.rotation, t);

    }
}
