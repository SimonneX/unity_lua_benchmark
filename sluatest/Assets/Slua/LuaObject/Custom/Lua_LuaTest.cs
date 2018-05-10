using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_LuaTest : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"LuaTest");
		createTypeMetatable(l,null, typeof(LuaTest),typeof(UnityEngine.MonoBehaviour));
	}
}
