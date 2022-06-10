using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Nice job you found the finish and have won the game~");
            Debug.Log("Nice job you found the finish and have won the game~");
            Debug.Log("Nice job you found the finish and have won the game~");
            Debug.Log("Nice job you found the finish and have won the game~");
            Debug.Log("Nice job you found the finish and have won the game~");
        }
    }
}
