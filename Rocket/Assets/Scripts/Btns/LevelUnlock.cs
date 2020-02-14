using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelUnlock : MonoBehaviour
{
    public Button[] levelUnlockButtons;

    void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached",1);
        print(levelReached);
        print("Hii");
        for(int i= 0; i < levelUnlockButtons.Length; i++)
        {
            if(i+1>levelReached)
            levelUnlockButtons[i].interactable = false;
        }
    }

    
    void Update()
    {
        
    }
}
