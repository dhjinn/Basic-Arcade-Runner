using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public float groundLength = 420f;
	public int counter = 0;
	public float obsDist = 50f;
	public GameObject obstacle;
	public GameObject ground;
	public float horizontalMin = -6f;
	public float horizontalMax = 6f;
	public Transform player;

	private Vector2 originPosition;
	// Use this for initialization


	void Start () {
		originPosition = transform.position;
		Spawn(0);
		MakeGround(0);
		counter++;
	}
	

	void MakeGround(int position) {
		Vector3 groundPosition = new Vector3 (0, 0, groundLength/2 + groundLength * position);
		Instantiate(ground, groundPosition, Quaternion.identity);
	}

	void Spawn(int position) {
		int i = 1;

		while (i < groundLength/obsDist) {
			Vector3 randomPosition1 = new Vector3 (Random.Range(horizontalMin, horizontalMax), 
			1f, (position * groundLength) + (obsDist * i));
			Instantiate(obstacle, randomPosition1, Quaternion.identity);
			Vector3 randomPosition2 = new Vector3 (Random.Range(horizontalMin, horizontalMax), 
			2.5f, (position * groundLength) + (obsDist * i));
			Instantiate(obstacle, randomPosition2, Quaternion.identity);
			Vector3 randomPosition3 = new Vector3 (Random.Range(horizontalMin, horizontalMax), 
			4f, (position * groundLength) + (obsDist * i));
			Instantiate(obstacle, randomPosition3, Quaternion.identity);
			i++;
		}
	}
	// Update is called once per frame
	void FixedUpdate () {
		if (player.position.z >= (groundLength * counter) - 100){
			MakeGround(counter);
			Spawn(counter);
			counter++;
		}
	}
}
