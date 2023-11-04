using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  INHERITENCE
public class Cylinder : Solid {

  //  POLYMORPHISM
  private void Update() {
    if(base.selected) {
      transform.Rotate(Vector3.right, 1.0f);
    }
  }

  //  POLYMORPHISM
  public override void Selected() {
    transform.Rotate(Vector3.forward, 90.0f);
  }

  //  POLYMORPHISM
  public override void Deselected() {
    transform.rotation = new Quaternion();
  }
}