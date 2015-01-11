using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterHolder : MonoBehaviour {
	private static characterBase[] _characterInfo;
	private const string _info ="XmlFiles/info";
	int spawn;
	void Start(){
		TextAsset info = Resources.Load<TextAsset> (_info);
		_characterInfo = xmlparse.parseCharacterBase (info.text);
		}
	public static characterBase[] RespawnControl(int Spawnpoint){
		List<characterBase> returnsList = new List<characterBase> ();
		foreach (characterBase a in _characterInfo) {
			if(a.spawnpoint <= Spawnpoint){
				returnsList.Add(a);
			}
				}
		return returnsList.ToArray ();
	}
}
