using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  INHERITENCE
public class Cube : Solid {

  //  POLYMORPHISM
  private void Update() {
    if(base.selected) {
      transform.Rotate(Vector3.up, 1.0f);
    }
  }

  //  POLYMORPHISM
  public override void Selected() {
    Debug.Log("Cube Selected");
  }

  //  POLYMORPHISM
  public override void Deselected() {
    transform.rotation = new Quaternion();
  }
}