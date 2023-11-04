using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour {
  //  ENCAPSULATION
  [SerializeField] private TMP_Text selectedText;
  [SerializeField] private TMP_Text instructionsText;

  //  ENCAPSULATION
  public string Selected { get; set; }

  //  POLYMORPHISM
  private void Start() {
    if(selectedText == null) Debug.LogError("Main UI: 'Selected Text' not assigned");
    if(instructionsText == null) Debug.LogError("Main UI: 'Instructions Text' not assigned");
  }

  //  POLYMORPHISM
  private void Update() {
    if(Selected == null) {
      selectedText.text = "Nothing Selected";
      instructionsText.gameObject.SetActive(true);
    } else {
      selectedText.text = Selected;
      instructionsText.gameObject.SetActive(false);
    }
  }
}