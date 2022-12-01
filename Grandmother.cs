using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grandmother : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private float movementTime = 0.25f;
    [SerializeField] private float movementDistance = 0.08f;

    private Vector3 moveDirection;

    private Transform t;

    private void SetMoveDirection()
    {
        switch (id)
        {
            case 1:
                if (Input.GetKeyDown(KeyCode.W))
                {
                    moveDirection = Vector3.right;
                }
                if (Input.GetKeyDown(KeyCode.S))
                {
                    moveDirection = Vector3.left;
                }
                
                if (Input.GetKeyDown(KeyCode.A))
                {
                    moveDirection = Vector3.forward;
                }
                if (Input.GetKeyDown(KeyCode.D))
                {
                    moveDirection = Vector3.back;
                }
                break;
            case 2:
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    moveDirection = Vector3.right;
                }
                if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    moveDirection = Vector3.left;
                }
        
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    moveDirection = Vector3.forward;
                }

                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    moveDirection = Vector3.back;
                }
                break;
        }
    }
    
    IEnumerator move()
    {
        yield return new WaitForSeconds(movementTime);
        t.position += moveDirection * movementDistance;
        moveDirection = Vector3.zero;
    }
    // Start is called before the first frame update
    void Start()
    {
        moveDirection = Vector3.zero;
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        SetMoveDirection();
        StartCoroutine(move());
    }
}
