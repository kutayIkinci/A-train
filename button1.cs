using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button1 : MonoBehaviour
{
    public FollowUp wp;
    public GameObject train;
    public BlackTrain bt;
    public YellowTrain yt;
    public GameObject train3;
    public GameObject train2;
    int counter = 0;
    public GameObject railroad1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   if (counter % 2 == 1)
        {
            railroad1.SetActive(false);
            if (train.transform.position.x == 0.33f && train.transform.position.y == -1.29f)
            {
                wp.waypointIndex = 12;
            }
        }
        else
        {
            railroad1.SetActive(true);
            if (train.transform.position.x == 0.33f && train.transform.position.y == -1.29f)
            {
                wp.waypointIndex = 5;
            }
        }


        if (counter % 2 == 1)
        {
            if (train2.transform.position.x == 0.33f && train2.transform.position.y == -1.29f)
            {
                bt.waypointIndex = 12;
            }
        }
        else
        {
            if (train2.transform.position.x == 0.33f && train2.transform.position.y == -1.29f)
            {
                bt.waypointIndex = 5;
            }
        }
        if (counter % 2 == 1)
        {
            if (train3.transform.position.x == 0.33f && train3.transform.position.y == -1.29f)
            {
                yt.waypointIndex = 12;
            }
        }
        else
        {
            if (train3.transform.position.x == 0.33f && train3.transform.position.y == -1.29f)
            {
                yt.waypointIndex = 5;
            }
        }
    }
   public void rotaDegistir()
    {    if(counter % 2 == 0) 
        {
            
            counter += 1;

        }
        else
        {
            counter += 1;
        }
            
        
    }
}
