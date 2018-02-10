using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickups : MonoBehaviour
{
    public GameObject cubeprefabvar;
    private GameObject cube;
    private Renderer[] objrend = new Renderer[8];

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
            objrend[i] = cube.GetComponent<Renderer>();
        }
        objrend[0].material.color = Color.magenta;
        objrend[1].material.color = Color.green;
        objrend[2].material.color = Color.grey;
        objrend[3].material.color = Color.magenta;
        objrend[5].material.color = Color.green;
        objrend[6].material.color = Color.grey;
        objrend[7].material.color = Color.magenta;
    }

    
}
