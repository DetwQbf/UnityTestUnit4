using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundaryDestroyer : MonoBehaviour
{
   

    private void OnTriggerExit2D(Collider2D other)
    {
        
        
            Destroy(other.gameObject);
            Destroy(other.gameObject);
        
    }
}
