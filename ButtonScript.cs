using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ButtonScript : MonoBehaviour
{
	// Start is called before the first frame update
	public Sprite Down;
	public Sprite Up;
	public UnityEngine.UI.Image Ke;


	public void DownBut()
	{
		

		Ke.sprite = Down;
	}


	public void UpBut()
	{
		Ke.sprite = Up;


	}
}
