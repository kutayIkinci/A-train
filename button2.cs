using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button2 : MonoBehaviour
{
    public FollowUp wp;
    public GameObject train;
    public GameObject train2;
    public GameObject train3;
    public YellowTrain yt;
    public BlackTrain bt;
    public int counter = 0;
    public GameObject railroad2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (counter % 2 == 1)
        {
            railroad2.SetActive(false);
            if (train.transform.position.x == -5.45f && train.transform.position.y == 1.39f)
            {
                wp.waypointIndex = 10;
                
            }
        }
        else
        {
            railroad2.SetActive(true);
            if (train.transform.position.x == -5.45f && train.transform.position.y == 1.39f)
            {
                wp.waypointIndex = 9;
            }
        }
        if (train.transform.position.x == -2.33f && train.transform.position.y == 1.47f)
        {
            wp.waypointIndex = 16;

        }



        if (counter % 2 == 1)
        {
            if (train2.transform.position.x == -5.45f && train2.transform.position.y == 1.39f)
            {
                bt.waypointIndex = 10;

            }
        }
        else
        {
            if (train2.transform.position.x == -5.45f && train2.transform.position.y == 1.39f)
            {
                bt.waypointIndex = 9;
            }
        }
        if (train2.transform.position.x == -2.33f && train2.transform.position.y == 1.47f)
        {
            bt.waypointIndex = 16;

        }
        if (counter % 2 == 1)
        {
            if (train3.transform.position.x == -5.45f && train3.transform.position.y == 1.39f)
            {
                yt.waypointIndex = 10;

            }
        }
        else
        {
            if (train3.transform.position.x == -5.45f && train3.transform.position.y == 1.39f)
            {
                yt.waypointIndex = 9;
            }
        }
        if (train3.transform.position.x == -2.33f && train3.transform.position.y == 1.47f)
        {
            yt.waypointIndex = 16;

        }
        if (train3.transform.position.x == 5.26f && train3.transform.position.y == 3.86f)
        {
            yt.waypointIndex = 16;

        }
    }
    public void rotaDegistir2()
    {
        if (counter % 2 == 0)
        {

            counter += 1;

        }
        else
        {
            counter += 1;
        }


    }
}
