using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrid : MonoBehaviour {

    //public Transform pointPrefab;
    public int height = 6;
    public float vertSeparation = 15;
    public int width = 6;
    public float horizontalSeparation = 15;

    public Transform[] rowPrefabs = new Transform[0];

    //using this to resize the rowPrefabs when changing the 
    //height of the grid within the editor
    void OnValidate()
    {
        if(rowPrefabs.Length != height)
        {
            Array.Resize<Transform> (ref rowPrefabs, height);
        }
    }


    Transform[] points;
    Vector3 scale = Vector3.one;
    void Awake()
    {
        int numPoints = height * width;
        points = new Transform[numPoints];
        Vector3 position;
        position.z = 0f;


        for (int i = 0; i < height; i++)
        {
            for(int j = 0; j < width; j++)
            {
                Transform point = Instantiate(rowPrefabs[i % height]);
                position.x =  (j - width/2f + .5f) * horizontalSeparation;
                //print(i % width * horizontalSeparation);
                position.y = (i-height/2f + .5f) * vertSeparation;

                point.localPosition = position;
                point.localScale = scale;
                point.SetParent(transform, false);

                points[i] = point;
            }
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
