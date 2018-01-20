using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour {

    public int hp = 100;
    public GameObject tankExplosition;

    public AudioClip tankExplosionAudio;

    public Slider hpSlider;

    private int hpTotal;
	// Use this for initialization
	void Start ()
	{
	    hpTotal = hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void TakeDamage()
    {
        if (hp <= 0) return;
        hp -= Random.Range(10, 20);
       hpSlider.value = (float)hp / hpTotal;
        if (hp <= 0)
        {
            //死亡
            AudioSource.PlayClipAtPoint(tankExplosionAudio,transform.position);
            GameObject.Instantiate(tankExplosition, transform.position, transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
