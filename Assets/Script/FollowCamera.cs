using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public FollowCamera instance;
    private Marimo_C player;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        player = FindObjectOfType<Marimo_C>();
    }

    // Update is called once per frame
    void Update()
    {
       
        this.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 10, player.transform.position.z - 30);
    }
}
