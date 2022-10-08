using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawGizmo : MonoBehaviour
{
    private void OnDrawGizmos()
    {

#if UNITY_EDITOR

        Gizmos.color = Color.yellow;

        Gizmos.DrawSphere(transform.position, 0.25f);

#endif
    }
}
