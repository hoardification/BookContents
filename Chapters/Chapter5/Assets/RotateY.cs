﻿/*
 * Chapter 5.2 Review
 *
 * Copyright © 2018 Alex Okita
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 */
using UnityEngine;
public class RotateY : MonoBehaviour
{
	void Update ()
    {
        transform.Rotate(new Vector3(0, 1f * Time.deltaTime, 0));
	}
}