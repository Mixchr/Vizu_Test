﻿using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TextController : MonoBehaviour {

	public TextMesh textField;

	public int letterLimit;

	// Use this for initialization
	void Start () {
		//textField = this.GetComponent<TextMesh> ();
		//SetText ("Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam lacinia neque est.");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetText(string newText){
		StringBuilder strB = new StringBuilder ();

		string[] textWords = newText.Trim().Split (' ');
		int wCount = 0;

		for (int i = 0; i < textWords.Length; i++) {
			string w = textWords [i];
			wCount += w.Length;
			if (wCount > letterLimit) 
			{
				strB.Append (System.Environment.NewLine);
				wCount = w.Length;
				//New Line
			} else 
			{
				strB.Append (" ");
				wCount++;
				//Keep going on the same line
			}
			strB.Append (w);
		}

		textField.text = strB.ToString();
	}
}
