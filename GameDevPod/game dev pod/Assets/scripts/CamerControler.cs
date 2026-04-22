using UnityEngine;

public class CamerControler : MonoBehaviour
{
    // the target of the player
   [SerializeField] private Transform target;
   // distance between the target and the camera
   [SerializeField] private Vector3 posOffest;

   void LateUpdate()
    {
        transform.position = target.position + posOffest;
    }
}
