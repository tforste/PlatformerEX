using UnityEngine;
using System.Collections;
using System.IO;

public class gameLogo : MonoBehaviour {

    public Texture logoTexture;

    void OnGUI()
    {
       // logoTex = Resources.Load("GameLogo") as Texture;
        logoTexture = Resources.Load("GameLogo") as Texture;

        //>>>Get the current width and height<<<
        int currentWidth = Screen.width;
        int currentHeight = Screen.height;

        //>>>Calculate the position and size of the logo<<<
        int logoWid = currentWidth / 8;
        int logoHt = currentHeight / 8;

        int logoYPos = currentHeight - logoHt;
        int logoXPos = currentWidth- logoWid; 

        //>>>Draw the Logo using the calculated values;
        GUI.DrawTexture(new Rect(logoXPos, logoYPos, logoWid, logoHt), logoTexture, ScaleMode.ScaleToFit, true, 0);
    }
}
