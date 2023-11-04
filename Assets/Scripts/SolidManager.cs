using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SolidManager : MonoBehaviour {
  //  ENCAPSULATION
  [SerializeField] private List<Solid> solids;

  //  ABSTRACTION
  public void DeselectAll() {
    foreach(Solid solid in solids) {
      solid.Deselect();
    }
  }
}