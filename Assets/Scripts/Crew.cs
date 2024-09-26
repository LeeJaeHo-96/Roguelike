using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Crew : MonoBehaviour
{
    private Camera cam;

    public bool isSelected;

    private bool isMoving;
    private float moveTime;

    private Vector2 startPosition;
    private Vector2 endPosition;


    private void Start()
    {
        isSelected = false;
        cam = Camera.main;
    }

    private void Update()
    {
        if (isSelected == true)
        {
            Move();
        }
        
    }

    private void Move()
    {
        if (isMoving == false && Input.GetKeyDown(KeyCode.Mouse1))
        {
            startPosition = transform.position;
            endPosition = cam.ScreenToWorldPoint(Input.mousePosition);
            moveTime = 0;
            isMoving = true;
        }

        if (isMoving)
        {
            moveTime += 0.5f * Time.deltaTime;
            float t = moveTime;
            transform.position = Vector2.Lerp(startPosition, endPosition, moveTime);

            if (t >= 1f)
            {
                transform.position = endPosition;
                isMoving = false;
            }
        }
    }

}
