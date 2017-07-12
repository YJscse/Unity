using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class csCubeAI : MonoBehaviour {

    public bool go = true;
    public GameObject[] waypoints;

    int num = 0;
    float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(gameObject.transform.position,
                                      waypoints[num].transform.position);

        if(go)
        {
            if(dist > 0.1)
            {
                Move();
            }
            else
            {
                if(num + 1 == waypoints.Length)
                {
                    num = 0;
                }
                else
                {
                    num++;
                }
            }
        }
	}

    void Move()
    {
        gameObject.transform.LookAt(waypoints[num].transform.position);
        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
