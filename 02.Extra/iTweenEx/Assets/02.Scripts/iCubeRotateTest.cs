using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iCubeRotateTest : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Fire1"))
        {
            Hashtable hash = new Hashtable();

            hash.Add("rotation", new Vector3(0, 720, 0));
            hash.Add("time", 3.0f);
            hash.Add("easetype", iTween.EaseType.easeOutExpo);
            hash.Add("looptype", iTween.LoopType.none);

            iTween.RotateTo(gameObject, hash);
        }
    }
}
