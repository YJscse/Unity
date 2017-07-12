﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iCubeScaleTest : MonoBehaviour {

    // Update is called once per frame
    void Update () {

        if (Input.GetButtonUp("Fire1"))
        {
            Hashtable hash = new Hashtable();

            hash.Add("x", 2.0f);
            hash.Add("y", 2.0f);
            hash.Add("z", 2.0f);
            hash.Add("speed", 3.0f);
            hash.Add("easetype", iTween.EaseType.easeInOutBack);
            hash.Add("looptype", iTween.LoopType.pingPong);


            iTween.ScaleTo(gameObject, hash);
        }
    }
}
