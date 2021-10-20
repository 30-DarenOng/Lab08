using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnRedObject;
    public GameObject SpawnBrownObject;
    public GameObject SpawnGreenObject;

    public int numRed = 1;
    public int brown = 2;
    public int numGreen = 3;
    public int rand;

    

    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
       


    }
    void RandomSpawn()
    {
        SpawnObjects();

    }

    void SpawnObjects()
    {
        rand = Random.Range(1, 4);
        if (rand == 1)
        {
            PositionY = Random.Range(4, -4f);
            this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
            Instantiate(SpawnRedObject, transform.position, transform.rotation);
        }
        if (rand == 2)
        {
            PositionY = Random.Range(4, -4f);
            this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
            Instantiate(SpawnBrownObject, transform.position, transform.rotation);
        }
        if (rand == 3)
        {
            PositionY = Random.Range(4, -4f);
            this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
            Instantiate(SpawnGreenObject, transform.position, transform.rotation);
        }

    }
}
