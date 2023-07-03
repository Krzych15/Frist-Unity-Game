
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Menu : MonoBehaviour
{
	public Button btnStart;
	public Button btnExit;

	/** Obiekt menu.*/
	private Canvas manu;

	void Start()
	{
		manu = (Canvas)GetComponent<Canvas>();
		btnStart = btnStart.GetComponent<Button>();
		btnExit = btnExit.GetComponent<Button>();

		Time.timeScale = 0;
		Cursor.visible = manu.enabled;
		Cursor.lockState = CursorLockMode.Confined;
	}

	void Update()
	{
		if (Input.GetKeyUp(KeyCode.Escape))
		{
			manu.enabled = !manu.enabled;
			Cursor.visible = manu.enabled;

			if (manu.enabled)
			{
				Cursor.lockState = CursorLockMode.Confined;
				Cursor.visible = true;
				Time.timeScale = 0;	
				btnStart.enabled = true; 
				btnExit.enabled = true; 
			}
			else
			{
				Cursor.lockState = CursorLockMode.Locked; 
				Cursor.visible = false;
				Time.timeScale = 1;
			}

		}
	}
	public void PrzyciskStart()
	{
		manu.enabled = false; 
		Time.timeScale = 1;
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked; 
	}
	public void wyjscie()
    {
		Application.Quit();
	}
	
	
}
