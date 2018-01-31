using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour {
    public bool moveLeft = false;
    public bool ableToChangeDirection = true;
    public float stepRate = 1f;
    public float stepDistance = 10f;
    public float dropDistance = 10f;
    private float deltaTime = 0f;
    private AlienMovement[] alienMovements;
    // Use this for initialization
    void Start () {
        alienMovements = transform.GetComponentsInChildren<AlienMovement>();
	}
	
	// Update is called once per frame
	void Update () {
        deltaTime += Time.deltaTime;
        if(stepRate < deltaTime)
        {
            StepGrid();
            FlipSprites();
            deltaTime = 0f;
            ableToChangeDirection = true;
        }

	}

    public void FlipSprites()
    {
        for (int i = 0; i < alienMovements.Length; i++)
        {
            if (alienMovements[i].isActiveAndEnabled)
            {
                alienMovements[i].ChangeSprite();
            }
        }
    }

    public void StepGrid()
    {
        Vector3 step;
        if (moveLeft)
        {
            step = new Vector3(-stepDistance, 0f, 0f);
        }
        else
        {
            step = new Vector3(stepDistance, 0f, 0f);
        }

        transform.position += step;

    }

    public void DropStep()
    {
        Vector3 step = new Vector3(0f, dropDistance, 0f);
        transform.position -= step;
    }
    public void ChangeDirection()
    {

        if (ableToChangeDirection)
        {
            moveLeft = !moveLeft;
            DropStep();
        }
        ableToChangeDirection = false;
    }
}
