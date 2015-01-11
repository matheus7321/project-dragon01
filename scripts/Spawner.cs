using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	private static GameObject _character;
	private static int characterId;
	public static void Create(int id){
		characterId = id;
		instantiate ();
		}
	private static void instantiate(){
		_character = GameObject.CreatePrimitive (PrimitiveType.Cube);

		}
	// Update is called once per frame
	void Update () {
		_character.transform.position = gameObject.transform.position;
	}
}
