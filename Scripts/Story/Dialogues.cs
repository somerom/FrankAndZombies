using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogues : GameController {

    string path = "Resources/Dialogues/";
    string position ="";
    public TextAsset GetNextLine()
    {
        path += base.GetPosition();
        base.SetPath(path);
        TextAsset tex = Resources.Load(path) as TextAsset;
        
        return tex;
    }
    public void SetNewPosition (string newpath)
    {
        position = base.GetPosition() + newpath;
        base.SetPosition(newpath);
    }
    public string GetDialoguePosition()
    {
        return position;
    }
    // TextAsset bindata = Resources.Load(name) as TextAsset;
    // Texture2D tex = new Texture2D(1, 1);



}
