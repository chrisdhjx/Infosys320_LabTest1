using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;
    public Color lerpedColor = Color.white;
    private float nextTime = 0.0f;
    public float period = 1.0f;
    public List<GameObject> cubey;


	// Use this for initialization
	void Start () {

        int totalCubes = 18;
        float totalDistance = 2.5f;

        cubey = new List<GameObject>();

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

            cubey.Add(newCube);
        }

        
        






    }
	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextTime)
        {
            nextTime += period;
            foreach (var cube in cubey)
            {
                Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
                cube.GetComponent<Renderer>().material.color = newColor;
            }

        }
     
	}
}
