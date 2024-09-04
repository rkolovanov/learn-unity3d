using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DeleteCollider : MonoBehaviour
{
  public void SetAllCollidersStatus(bool active)
  {
    foreach (Collider c in GetComponents<Collider>())
    {
      c.enabled = active;
    }
  }

  void OnCollisionEnter(Collision collision)
  {
    if (collision.gameObject.name == "Ball")
    {
      SetAllCollidersStatus(false);
    }
  }
}
