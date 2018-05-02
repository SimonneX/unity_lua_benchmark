using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;

public class Test : MonoBehaviour {

    LuaState state = null;   

	void Start () 
    {
        new LuaResLoader();
        state = new LuaState();
        state.Start();
        LuaBinder.Bind(state);
        state.DoFile("test.lua");

        LuaFunction func = state.GetFunction("test");
        func.BeginPCall();
        func.Push(this.gameObject);
        func.PCall();
        func.EndPCall();
        func.Dispose();
        func = null;    
	}

    // Update is called once per frame
    void Update()
    {

    }
}
