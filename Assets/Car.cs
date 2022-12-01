using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{

    private const float Border = -5;
    private Transform t;

    private int id;

    private Vector3 startPosition;

    public void SetId(int newId)
    {
        id = newId;
    }

    public void SetStartPosition(Vector3 position)
    {
        startPosition = position;
    }

    public void Reused()
    {
        t.position = startPosition;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        t.position += Vector3.left * Time.deltaTime;
        if (t.position.x < Border)
        {
            Reused();
        }
        
    }
}
