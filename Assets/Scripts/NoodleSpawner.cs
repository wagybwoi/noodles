using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoodleSpawner : MonoBehaviour
{
    public GameObject noodPrefab;
    public Vector2 noodMatrix = new Vector2(1, 1);
    public float noodSpacing = 0.5f;

    void Start()
    {
        for (int x = 0; x < noodMatrix.x; x++)
        {
            for (int z = 0; z < noodMatrix.y; z++)
            {
                Instantiate(
                noodPrefab, 
                new Vector3(
                    x*noodSpacing - ((noodMatrix.x-1)*noodSpacing)/2,
                    this.transform.position.y,
                    z*noodSpacing - ((noodMatrix.y-1)*noodSpacing)/2),
                Quaternion.identity);
            }
        }
    }
}
