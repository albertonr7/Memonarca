using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound {

	public string nombre;
	public AudioClip clip;

	[Range(0f, 1f)]
	public float volume;

	[Range(.1f, 3f)]
	public float pitch = 1f;

	public bool loop;

	[HideInInspector]
	public AudioSource source;

}
