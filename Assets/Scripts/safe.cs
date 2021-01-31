using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class safe : MonoBehaviour
{
	GameObject obj;
	GameObject itemsafed;
	[SerializeField]
	Text codeText;
	string codeTextValue = "";
	public bool safestatus;


	private void Awake()
	{
		obj = GameObject.FindGameObjectWithTag("GameController");
		itemsafed = GameObject.FindGameObjectWithTag("Item");
		safestatus = obj.GetComponent<DontDestroy>().safeopen;
		if (safestatus)
		{
			Destroy(transform.parent.gameObject);
			Destroy(codeText);
		}
		else
			itemsafed.GetComponent<ObjectivePickup>().tangible = false;

	}

	// Update is called once per frame
	void Update()
	{



		codeText.text = codeTextValue;

		if (codeTextValue == "6453")
		{
			obj.GetComponent<DontDestroy>().safeopen = true;
			itemsafed.GetComponent<ObjectivePickup>().tangible = true;
			Destroy(transform.parent.gameObject);
			Destroy(codeText);
		}

		if (codeTextValue.Length >= 4)
			codeTextValue = "";
	}

	public void AddDigit(string digit)
	{
		codeTextValue += digit;
	}

}

