using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.IO;
public class xmlparse {
	public static characterBase[]parseCharacterBase(string content){
		XmlReader reader = XmlReader.Create (new StringReader (content));
		List<characterBase> characters = new List<characterBase> ();
		characterBase current = null;
		while (reader.Read()) {
			if(reader.IsStartElement("character")){
				if(current != null){
					characters.Add(current);


				}
				current = new characterBase();
			}
			if(current != null){
				if(reader.IsStartElement("id")){
					current.Id = reader.ReadElementContentAsInt();
			}
				if(reader.IsStartElement("name")){
					current.Name = reader.ReadElementContentAsString();
				}
				if(reader.IsStartElement("damage")){
					current.Damage = reader.ReadElementContentAsFloat();
				}
				if(reader.IsStartElement("defense")){
					current.Defense = reader.ReadElementContentAsFloat();
				}
				if(reader.IsStartElement("velocity")){
					current.Velocity = reader.ReadElementContentAsFloat();
				}
				if(reader.IsStartElement("spawnpoint")){
					current.spawnpoint = reader.ReadElementContentAsInt();
				}
		}
	}
		if (current != null) {
			characters.Add(current);
				}
		return characters.ToArray ();
  }
}
