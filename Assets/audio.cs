using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour {

	//サウンド設定
	public AudioClip sound01;
	
	void OnCollisionEnter2D (Collision2D collision){

		if ( collision.gameObject.tag == "UnityChanTag" ){

			//Cube衝突時にボリュームを0にする
			GetComponent<AudioSource>().volume = 0; 

		} else {

			AudioSource.PlayClipAtPoint(sound01, transform.position);

		}

	}

}
