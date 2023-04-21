using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{
    public GameObject prefab;
    

    // Start is called before the first frame update
    void Start()
    {
        int Lamps = 10;

        do
        {
            Instantiate(prefab, new Vector3(-1, 0, 5), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 15), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 25), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 35), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 45), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 55), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 65), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 75), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 85), transform.rotation);
            Lamps--;
            Instantiate(prefab, new Vector3(-1, 0, 95), transform.rotation);
            Lamps--;

        }
        while (Lamps > 0);
        

     
       
        
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);

        }
    }
}
