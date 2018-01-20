using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankAttack : MonoBehaviour {

    // Use this for initialization
    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    public float shellSpeed = 10;
    private Transform firePosition;
    public AudioClip shotAudio;
	void Start () {
        firePosition = transform.Find("FirePosition");	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(shotAudio,transform.position);
            GameObject go = Instantiate(shellPrefab, firePosition.position, firePosition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
	}
}
