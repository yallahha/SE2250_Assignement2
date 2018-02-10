using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour
{
    public GameObject cubeprefabvar;
    private GameObject cube;
    Renderer objrend;

    // Use this for initialization
    void Start()
    {
        
        for (int i = 0; i < 8; i++)
        {
            float angle = i * Mathf.PI * 2 / 8;
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * -6; // original line

            Vector3 currentPos = cubeprefabvar.transform.position;
            Vector3 desiredPos = new Vector3(currentPos.x + pos.x, currentPos.y + pos.y, currentPos.z + pos.z);
            cubeprefabvar.transform.position = desiredPos;
            cube = Instantiate(cubeprefabvar);
            //cube[i].GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1), Random.Range(0, 1));
            objrend = cube.GetComponent<Renderer>();
            objrend.material.color = new Color(Random.value, Random.value, Random.value);


        }
    }

    
}
