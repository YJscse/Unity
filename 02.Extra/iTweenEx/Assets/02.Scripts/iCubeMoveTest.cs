using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iCubeMoveTest : MonoBehaviour {

    public Transform moveTarget;

	// Update is called once per frame
	void Update () {
		
        if(Input.GetButtonUp("Fire1"))
        {
            Hashtable hash = new Hashtable();

            hash.Add("position", moveTarget);
            hash.Add("orienttopath", true);
            hash.Add("looktime", 1.0f);
            hash.Add("time", 3.0f);
            hash.Add("easetype", iTween.EaseType.easeInExpo);


            iTween.MoveTo(gameObject, hash);
        }
	}
}
