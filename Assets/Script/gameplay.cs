using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameplay : MonoBehaviour {
	public Sprite[] soal; 
	public string[] jawaban;
	public string[] jawaban2;

	public Text text_skor;
	public Text skorAkhir;
	public Image text_soal;

	public InputField input_jawaban;

	public GameObject selesai, bank_soal;
	public GameObject benar, salah;

	public Soundsfx _soundfx;
	int urutan_soal=-1, skor=0;

	// Use this for initialization
	void Start () {
		tampil_soal ();
	}

	void tampil_soal(){
		urutan_soal++;
		text_soal.sprite = soal [urutan_soal];
	}

	public void jawab(){
		if (urutan_soal < soal.Length -1) {
			if (input_jawaban.text == jawaban [urutan_soal] || input_jawaban.text == jawaban2 [urutan_soal]) {
				_soundfx.PlayRightAnswer();
				benar.SetActive(false);
				benar.SetActive(true);
				salah.SetActive(false);
				skor += 10;
			} else {
				_soundfx.PlayWrongAnswer();
				benar.SetActive(false);
				salah.SetActive(false);
				salah.SetActive(true);
			}
			input_jawaban.text = "";
			tampil_soal ();
		} else {
			if (input_jawaban.text == jawaban [urutan_soal] || input_jawaban.text == jawaban2 [urutan_soal]) {
				skor += 10;
			}
			selesai.SetActive (true);
			bank_soal.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		text_skor.text = skor.ToString ();
		skorAkhir.text = skor.ToString ();
	}
}
