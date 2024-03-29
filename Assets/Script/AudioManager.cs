﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
	private static AudioManager instance;

	private AudioSource player;

	void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(transform.gameObject);

		}
	}

	// Start is called before the first frame update
	void Start()
	{
		DontDestroyOnLoad(this.gameObject);

		player = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
	{
		Scene currentScene = SceneManager.GetActiveScene();

		if (currentScene.name == "Quiz" || currentScene.name == "Materi" || currentScene.name == "Essay"
		|| currentScene.name == "MemoryGames 8pcs" || currentScene.name == "MemoryGames 12pcs")
		{
			Destroy(gameObject);
		}
	}  
}
