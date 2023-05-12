using UnityEngine.Audio;
using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AudioManager : MonoBehaviour
{

	public Sound[] sounds;
	public static AudioManager instance;

	// Aplica los ajustes a los sonidos y corrobora si ya se tiene un
	// AudioManager en la escena
	void Awake()
	{
		if(instance == null)
		{
			instance = this;
		}
		else
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);		

		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
		}
	}

	/*void Start()
	{
		Play();
	}*/

	// Busca el sonido en el arreglo y lo reproduce, sino lo encuentra
	// da un aviso en la consola
	public void Play(string nombre)
	{
		//Sound s = Array.Find(sounds, item => item.nombre == sound);
		Sound s = Array.Find(sounds, sound => sound.nombre == nombre);
		if (s == null)
		{
			Debug.LogWarning("Sonido: " + nombre + " no encontrado!");
			return;
		}
		s.source.Play();
		StartCoroutine(Esperar());
	}

	IEnumerator Esperar()
    {
        yield return new WaitForSeconds(3f);
    }

}
