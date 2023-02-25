using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Copy_motion : MonoBehaviour
{
	public GameObject origin_Root;
	public GameObject target_Root;
	public float offset = -3;
    // Start is called before the first frame update
    void Start()
    {
        Transform origin_trans = origin_Root.transform;
		var origin_trans_child = origin_trans.GetComponentsInChildren<Transform>();
		Debug.Log(origin_trans_child.Length);
		for (int i = 0; i<origin_trans_child.Length;i++){
		Debug.Log(origin_trans_child[i].name);
		}
		
    }

    // Update is called once per frame
    void Update()
    {
        Transform origin_trans = origin_Root.transform;
		Transform target_trans = target_Root.transform;
		var origin_trans_child = origin_trans.GetComponentsInChildren<Transform>();
		var target_trans_child = target_trans.GetComponentsInChildren<Transform>();
		
		for (int i = 0; i<origin_trans_child.Length;i++){
		Transform temp = origin_trans_child[i].transform;
		Transform temp_target = target_trans_child[i].transform;
		Vector3 pos = temp.position;
		pos.x += offset;
		temp_target.position = pos;
		temp_target.rotation = temp.rotation;
		}
		
		
    }
}
