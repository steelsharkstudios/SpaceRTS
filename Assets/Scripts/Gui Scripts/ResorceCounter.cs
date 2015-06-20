using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResorceCounter : MonoBehaviour {
	public Text Uranium;
	public Text Titanium;
	public Text CurrentUnit;
	public Text MaxUnit;

	private int UraniumCount;
	private int TitaniumCount;
	private int CurrentUnitCount;
	private int MaxUnitsCount;

	// Use this for initialization
	void Start () {
		UraniumCount = 250;
		TitaniumCount = 500;
		CurrentUnitCount = 0;
		MaxUnitsCount = 200;

		Uranium.text = UraniumCount + "";
		Titanium.text = TitaniumCount + "";
		CurrentUnit.text  = CurrentUnitCount + "";
		MaxUnit.text  = MaxUnitsCount + "";
	}
	
	public int getUranium(){
		return UraniumCount;
	}

	public int getTitanium(){
		return TitaniumCount;
	}

	public int getCurrentUnitCount(){
		return CurrentUnitCount;
	}

	public void changeUranium(int x){
		UraniumCount = UraniumCount + x;
		Uranium.text = UraniumCount + "";
	}

	public void changeTitanium(int x){
		TitaniumCount = UraniumCount + x;
		Titanium.text = TitaniumCount + "";
	}

	public void unitCreated(){
		CurrentUnitCount++;
		CurrentUnit.text = CurrentUnitCount + "";
	}

	public void unitDestroyed(){
		CurrentUnitCount--;
		CurrentUnit.text = CurrentUnitCount + "";
	}

}
