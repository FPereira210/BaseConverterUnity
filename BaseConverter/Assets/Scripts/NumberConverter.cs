using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NumberConverter : MonoBehaviour
{

	[SerializeField]
	private InputField userInput;
	[SerializeField]
	private Dropdown menuDrop;
	[SerializeField] private Text bina, octa, dec, hex, excText;

	private int currentBase;


	void Start ()
	{
		GetBase (0);

	}


	public void GetInput (string number)
	{

		try {
			userInput.text = "";
			excText.text = "";

			int num = System.Convert.ToInt32 (number, currentBase);
			print (num);

			dec.text = System.Convert.ToString (num);

			hex.text = System.Convert.ToString (num, 16);
            
			octa.text = System.Convert.ToString (num, 8);
      
			bina.text = System.Convert.ToString (num, 2);


			Debug.Log ("HEX: " + System.Convert.ToString (num, 16));
			Debug.Log ("Oct: " + System.Convert.ToString (num, 8));
			Debug.Log ("Binary: " + System.Convert.ToString (num, 2));
            
            
		} catch (Exception e) {
			Debug.Log ("Type the appropriate number system");
			excText.color = Color.red;
			excText.text = ("Type the appropriate number system");

		}

	}

	public void GetBase (int baseNumber)
	{

		switch (menuDrop.value) {

		case 0:
			currentBase = 10;
			break;
		case 1:
			currentBase = 16;
			break;
		case 2:
			currentBase = 8;
			break;
		case 3:
			currentBase = 2;
			break;

		default:
			break;
		}


		Debug.Log ("Base: " + currentBase);
	}


}
