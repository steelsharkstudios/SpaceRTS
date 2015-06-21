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
		MaxUnitsCount = 10;

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
	public void unitCreated(int x){
		CurrentUnitCount = CurrentUnitCount + x;
		CurrentUnit.text = CurrentUnitCount + "";
	}
	//subtracts one from the current ammount of units
	public void unitDestroyed(int x){
		CurrentUnitCount = CurrentUnitCount - x;
		CurrentUnit.text = CurrentUnitCount + "";
	}
	//used for addind and subtracting from the maxsupply
	public void changeMaxUnits(int x){
		MaxUnitsCount = MaxUnitsCount + x;
		MaxUnit.text = MaxUnitsCount + "";
	}
}
