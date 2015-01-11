using UnityEngine;
using System.Collections;

public class spawn_point : MonoBehaviour {

	public int id;
	public bool selected = false;
	void OnGUI(){
		if (selected) {
			characterBase[] possibleSpawn = CharacterHolder.RespawnControl(id);
			for(int i = 0; i < possibleSpawn.Length;i++){
				characterBase current = possibleSpawn[i];
				if(GUI.Button(new Rect(0,40*i,400,40),current.Name)){
					Spawner.Create(current.Id);
				}
				}

	}
}
}