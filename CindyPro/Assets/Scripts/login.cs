using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  XLua;
public class login : MonoBehaviour
{
	private LuaEnv newluaenc;
	// Use this for initialization
	void Start ()
	{
		newluaenc = new LuaEnv();
		newluaenc.DoString("print('ddddd')");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
