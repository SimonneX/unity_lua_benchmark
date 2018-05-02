﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_AnimationBlendModeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(UnityEngine.AnimationBlendMode));
		L.RegVar("Blend", get_Blend, null);
		L.RegVar("Additive", get_Additive, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<UnityEngine.AnimationBlendMode>.Check = CheckType;
		StackTraits<UnityEngine.AnimationBlendMode>.Push = Push;
	}

	static void Push(IntPtr L, UnityEngine.AnimationBlendMode arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(UnityEngine.AnimationBlendMode), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Blend(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.AnimationBlendMode.Blend);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Additive(IntPtr L)
	{
		ToLua.Push(L, UnityEngine.AnimationBlendMode.Additive);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		UnityEngine.AnimationBlendMode o = (UnityEngine.AnimationBlendMode)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

