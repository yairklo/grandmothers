using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    private const int numCars = 12;
    private Car[] cars = new Car[numCars];
    private GameObject temp;
    private int numCarsRow = 6;
    private bool flag = true;
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < numCars; i++)
        {
            temp = Instantiate(Resources.Load("Car")) as GameObject;
            cars[i] = temp.GetComponent<Car>();
            cars[i].transform.parent = transform;
            cars[i].SetId(i);
            if (i < numCarsRow)
            {
                cars[i].SetStartPosition(i * new Vector3(0, 0, 1.25f) * Mathf.Pow(-1, i) + Vector3.right * 5);
            }
            else
            {
                cars[i].SetStartPosition((i - numCarsRow) * new Vector3(0, 0, 1.25f) * Mathf.Pow(-1, i) + Vector3.right * 8);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            flag = false;
            for (int i = 0; i < numCars; i++)
            {
                cars[i].Reused();
            }

        }
    }
}
