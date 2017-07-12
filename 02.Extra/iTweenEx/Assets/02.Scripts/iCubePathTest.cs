using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iCubePathTest : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonUp("Fire1"))
        {
            Hashtable hash = new Hashtable();

            hash.Add("path", iTweenPath.GetPath("MyPath1"));
            hash.Add("movetopath", true);
            hash.Add("orienttopath", true);
            hash.Add("looktime", 1.0f);
            hash.Add("time", 3.0f);
            hash.Add("easetype", iTween.EaseType.easeInOutQuart);
            hash.Add("looptype", iTween.LoopType.none);

            iTween.MoveTo(gameObject, hash);

        }
    }
}
