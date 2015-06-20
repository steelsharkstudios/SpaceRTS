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
	//returns the uranium left
	public int getUranium(){
		return UraniumCount;
	}
	//returns the tiranium left
	public int getTitanium(){
		return TitaniumCount;
	}
	//returns the current ammount of units
	public int getCurrentUnitCount(){
		return CurrentUnitCount;
	}
	//changes the current uranium value accepts negetive numbers aswell
	public void changeUranium(int x){
		UraniumCount = UraniumCount + x;
		Uranium.text = UraniumCount + "";
	}
	//changes the current titanium value accepts negetive numbers aswell
	public void changeTitanium(int x){
		TitaniumCount = UraniumCount + x;
		Titanium.text = TitaniumCount + "";
	}
	//adds one to the current ammount of units
	public void unitCreated(){
		CurrentUnitCount++;
		CurrentUnit.text = CurrentUnitCount + "";
	}
	//subtracts one from the current ammount of units
	public void unitDestroyed(){
		CurrentUnitCount--;
		CurrentUnit.text = CurrentUnitCount + "";
	}

}
