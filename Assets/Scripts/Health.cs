using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {


	public const int maxHealth = 100;
	public int currentHealth = maxHealth;
	public RectTransform healthBar;


	public void TakeDamage(int val) {
		currentHealth -= val;

		healthBar.sizeDelta = new Vector2 (currentHealth, healthBar.sizeDelta.y);

		if (currentHealth <= 0) {
			currentHealth = 0;
			Debug.Log ("Dead!");
		}
	}


}
