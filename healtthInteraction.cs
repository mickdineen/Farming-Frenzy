using UnityEngine;
using System.Collections;

public class characterhealth : MonoBehaviour 
{
	public int health = 100;

void Start () 
{
}

void Update () 
{
}

public void OnTriggerEnter(Collider other)
{
	if(other.gameObject.tag=="hole")
	Destroy(gameObject);	
}

public void OnCollisionEnter(Collision collision)
{
	if(collision.transform.tag == "rock")
{
	PlayerHealth life = (PlayerHealth) collision.transform.GetComponent("PlayerHealth");

if(life)
   life.AdjustCurrentHealth(-20);
 
}
}
}

