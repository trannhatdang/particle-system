using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiscript : MonoBehaviour
{
	[SerializeField] ParticleSystem part;
	public static uiscript instance;
	void Awake()
	{
		if(instance && instance != this)
		{
			Destroy(this.gameObject);
		}
		else
		{
			instance = this;
		}
	}

	// Start is called before the first frame update
	void Start()
	{


	}

	// Update is called once per frame
	void Update()
	{

	}
	public void PlayParticleSys()
	{	
		if(!part) return;

		testParticleSystem test = part.gameObject.GetComponent<testParticleSystem>();
		test.play_part();

	}
}
