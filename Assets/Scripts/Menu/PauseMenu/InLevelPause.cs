using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InLevelPause : MonoBehaviour
{
  public Button pause_btn;
  public PauseMenu pasueMenu;
  void Start(){
      //pause_btn = gameObject.GetComponent<Button>();
      //PauseMenu = GameObject.Find("PauseMenu").GetComponent<Canvas>();
      pause_btn.onClick.AddListener(ShowPauseMenu);
  }
 void Update()
    {

    }


  void ShowPauseMenu(){
      //Cursor.lockState = CursorLockMode.Confined;
      //PauseMenu.enabled = true;
      pasueMenu.Setup();
      Debug.Log("Pause Menu Show up");
      
  }
}
