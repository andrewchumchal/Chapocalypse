﻿using UnityEngine;
using System.Collections;

public class TennisBall : MonoBehaviour
{
	public float speed = 2f;
	private SpriteRenderer spriteRenderer;
	public int Points;

	void Start()
	{
		spriteRenderer = GetComponentInChildren<SpriteRenderer>();
	}

	// Update is called once per frame
	void Update () 
	{
		transform.position += Time.deltaTime * speed * transform.forward;

		if(spriteRenderer.isVisible == false)
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D aCollider)
	{
		if(aCollider.gameObject.layer == LayerMask.NameToLayer("Enemy"))
		{
			Destroy(aCollider.gameObject);
			Destroy(gameObject);

		}
	}
}
