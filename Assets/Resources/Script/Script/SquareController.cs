using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{
    public int number;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Flusk();
        //if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y == 0)
        //{
        //    this.gameObject.transform.position += new Vector3(3, 0, 0);
        //    Debug.LogError(this.gameObject.transform.position.x);
        //}
        //else if (this.gameObject.transform.position.x >= 3 && this.gameObject.transform.position.y == 0)
        //{
        //    this.gameObject.transform.position += new Vector3(0, 3, 0);
        //    Debug.Log(this.gameObject.transform.position.y);
        //}
        //else if (this.gameObject.transform.position.x >= 3 && this.gameObject.transform.position.y >= 3)
        //{
        //    this.gameObject.transform.position -= new Vector3(3, 0, 0);
        //    Debug.LogError("Hi3");
        //}
        //else if (this.gameObject.transform.position.x == 0 && this.gameObject.transform.position.y >= 3)
        //{
        //    this.gameObject.transform.position -= new Vector3(0, 3, 0);
        //    Debug.LogError("Hi4");
        //}

    }
    public void Flusk()
    {
        var pos = this.gameObject.transform.position;
        this.gameObject.transform.Rotate(0, 0, 1);
        if (pos.x == 0 && pos.y == 0)
        {
            pos += new Vector3(number, 0, 0);
            Debug.LogError(pos.x + " toa do x ");
            Debug.LogWarning(pos.y + " toa do y ");
        }
        else if (pos.x >= number && pos.y == 0)
        {
            pos += new Vector3(0, number, 0);
            Debug.Log(pos.y);
        }
        else if (pos.x >= number && pos.y >= number)
        {
            pos += new Vector3(-number, 0, 0);
            Debug.LogError(pos.x);
        }
        else if (pos.x == 0 && pos.y >= number)
        {
            pos += new Vector3(0, -number, 0);
            Debug.Log(pos.y);
        }
    }

}
