using UnityEngine;
using System.Collections;

public class ObjectFollowPlayer2D : MonoBehaviour {

	public bool followOnX = false;
	public bool followOnY = false;
	public float offsetX = 0f;
	public float offsetY = 0f;
	public GameObject player;	
	
	// Update is called once per frame
	void Update () {
		if(player != null){
			if(followOnX && followOnY){
				this.transform.position = new Vector3 (player.transform.position.x + offsetX, player.transform.position.y + offsetY, this.transform.position.z);
			}
			else if(followOnX){
				this.transform.position = new Vector3(player.transform.position.x + offsetX,this.transform.position.y,this.transform.position.z); 
			}
			else if(followOnY){
				this.transform.position = new Vector3(this.transform.position.x,player.transform.position.y + offsetY, this.transform.position.z); 
			}
		}
		else{
			Debug.LogError("Player was not initialized");
		}
	}
}
