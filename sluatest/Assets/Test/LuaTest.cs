using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

[CustomLuaClass]
public class LuaTest : MonoBehaviour {

	LuaSvr l;
	LuaState ls;
	// Use this for initialization
	void Start () {
		l = new LuaSvr();
        l.init(null, () =>
        {
			l.start("LuaTest");
        });
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
