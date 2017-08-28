using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;
    public randomcolor randomcol;

	// Use this for initialization
	void Start () {

        int totalCubes = 18;
        float totalDistance = 2.5f;

        for (int i = 0; i < totalCubes; i++) 
        {
            float perc = i / (float)totalCubes;
            float sin = Mathf.Sin(perc * Mathf.PI / 2);

            float x = 0.8f + sin + totalDistance;
            float y = 5.0f;
            float z = 0.0f;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);

            newCube.GetComponent<Mycudescript>().SetSize(.5f * (1.0f - perc) );
            newCube.GetComponent<Mycudescript>().rotateSpeed = .2f + perc*3.0f;

            var changecolor = newCube.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        
        






    }
	
	// Update is called once per frame
	void Update () {

     
	}
}
