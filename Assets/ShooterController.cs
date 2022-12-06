using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform spawnTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject newBullet = Instantiate(projectilePrefab, null);
            newBullet.transform.position = spawnTransform.position;
            newBullet.transform.rotation = spawnTransform.rotation;
        }
    }
}
