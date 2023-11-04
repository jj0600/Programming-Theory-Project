using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Solid : MonoBehaviour {
  //  ENCAPSULATION
  private MainUI uiController;
  protected bool selected;

  //  ENCAPSULATION
  [SerializeField] private SolidManager solidManager;

  //  POLYMORPHISM
  private void Start() {
    uiController = GameObject.FindWithTag("UIController").GetComponent<MainUI>();
    selected = false;

    if(uiController == null) Debug.LogError("Solid: No UIController");
    if(solidManager == null) Debug.LogError("Solid: No SolidManager");
  }

  private void OnMouseDown() {
    Select();
  }

  //  ABSTRACTION
  private void Select() {
    if(!selected) {
      solidManager.DeselectAll();
      selected = true;
      uiController.Selected = gameObject.name;
      Selected();
    }
  }

  //  ABSTRACTION
  public void Deselect() {
    if(selected) {
      selected = false;
      Deselected();
    }
  }

  //  INHERITENCE
  public abstract void Selected();
  public abstract void Deselected();
}