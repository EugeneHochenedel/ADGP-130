﻿using UnityEngine;
using System.Collections;

public class BulletDespawn : MonoBehaviour
{
    float BulletTime;
	
	// Update is called once per frame
	void Update ()
    {
        BulletTime += Time.deltaTime;

        if (BulletTime >= 1.0f)
        {
            Destroy(this.gameObject);
        }

    }
}
