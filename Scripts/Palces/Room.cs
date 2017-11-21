using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room {

    private string name;
    private Room nextRoom;

    Room()
    {

    }

	public void ChangeRoom()
	{

	}

    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }

    public void SetNetxRoom(Room nr)
    {
        this.nextRoom = nr;
    }
    public Room GetNextRoom ()
    {
        return this.nextRoom;
    }
    
}
