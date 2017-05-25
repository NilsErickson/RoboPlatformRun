using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
	public class Completelv2B : MonoBehaviour
	{
		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player")
			{
				Application.LoadLevel ("Level 3B");
			}
		}
	}
}