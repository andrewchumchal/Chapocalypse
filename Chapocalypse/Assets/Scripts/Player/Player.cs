﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mouseWorldPos.z = 0f;
		transform.LookAt(mouseWorldPos);

		if(Input.GetButtonDown("Fire1"))
		{
			GameObject bullet = GameObject.Instantiate(bulletPrefab);
			bullet.transform.position = transform.position;
			bullet.transform.forward = transform.forward;
		}
	}

	void OnTriggerEnter2D (Collider2D aCollider)
	{
		if (aCollider.gameObject.layer == LayerMask.NameToLayer ("Enemy")) 
		{
			Destroy (aCollider.gameObject);
			//Destroy(gameObject);
		}

		if(aCollider.gameObject.tag == "Enemy")
		{
			healthManager.currentHealth = healthManager.currentHealth - dogAttack.dogValue;
		}
	}
}