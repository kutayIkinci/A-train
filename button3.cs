using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button3 : MonoBehaviour
{
    public FollowUp wp;
    public BlackTrain bt;
    public GameObject train;
    public GameObject train2;
    public GameObject train3;
    public YellowTrain yt;
    public int counter = 0;
    public GameObject railroad3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter % 2 == 1)
        {
            railroad3.SetActive(false);
            if (train.transform.position.x == 2.56f && train.transform.position.y == 3.83f)
            {
                wp.waypointIndex = 15;
            }
        }
        else
        {
            railroad3.SetActive(true);
            if (train.transform.position.x == 2.56f && train.transform.position.y == 3.83f)
            {
                wp.waypointIndex = 14;
            }
        }



        if (counter % 2 == 1)
        {
            if (train2.transform.position.x == 2.56f && train2.transform.position.y == 3.83f)
            {
                bt.waypointIndex = 15;
            }
        }
        else
        {
            if (train2.transform.position.x == 2.56f && train2.transform.position.y == 3.83f)
            {
                bt.waypointIndex = 14;
            }
        }
        if (counter % 2 == 1)
        {
            if (train3.transform.position.x == 2.56f && train3.transform.position.y == 3.83f)
            {
                yt.waypointIndex = 15;
            }
        }
        else
        {
            if (train3.transform.position.x == 2.56f && train3.transform.position.y == 3.83f)
            {
                yt.waypointIndex = 14;
            }
        }
    }
    public void rotaDegistir3()
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
