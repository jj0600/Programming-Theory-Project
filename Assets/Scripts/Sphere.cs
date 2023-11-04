using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  INHERITENCE
public class Sphere : Solid {

  //  POLYMORPHISM
  public override void Selected() {
    Vector3 selectedPosition = transform.position;
    selectedPosition.y++;
    transform.position = selectedPosition;
  }

  //  POLYMORPHISM
  public override void Deselected() {
    Vector3 deselectedPosition = transform.position;
    deselectedPosition.y--;
    transform.position = deselectedPosition;
  }
}