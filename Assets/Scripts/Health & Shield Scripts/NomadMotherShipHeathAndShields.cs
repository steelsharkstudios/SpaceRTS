using UnityEngine;
using System.Collections;

public class NomadMotherShipHeathAndShields : MonoBehaviour {
	private int shields;
	private int maxShields;
	private int maxHealth;
	private int health;
	private float timeOfLastDamage;
	private float currentTime;
	private int rateOfShieldRecharge;

	// Use this for initialization
	void Start () {
		int shields = 500;
		int health = 1500;
		int maxShields = shields;
		int maxHealth = health;
		rateOfShieldRecharge = (int)((shields / 100) * 5);
	}

	void Update(){
		shieldRecharge ();
	}

	public void damage(int damage){
		int damageleft = 0;
		int damageholder = 0;
		timeOfLastDamage = Time.time;
		//checks to see if the shields can take the dammage going to be given
		if (damage > shields && shields != 0) {
			damageholder = damage;
			damage = damage - shields;
			damageleft = damage;
			damage = damageholder
		}
		//gives damage to the shield
		if(damageleft == 0){
				shields = shields - damage;
		}else{//gives damage to the structure
			if((health - damageleft) > 0){
				shields = 0;
				health = health - damageleft;
			}else{
				Destroyed();
			}
		}
	}

	void shieldRecharge(){
		if((Time.time - timeOfLastDamage) >= 5){
			if(shields != maxShields){
				shields = shields + rateOfShieldRecharge;
			}
		}
	}

	//called when health == 0, invokes the game over script
	void Destroyed(){

	}


}
