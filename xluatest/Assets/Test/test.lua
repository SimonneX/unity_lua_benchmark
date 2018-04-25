
function test()
	-- 1)属性的读取和设置
	local t = os.clock()
	for i = 1, 200000 do
		local v = self.transform.position
		self.transform.position = v
	end
	print("test1/lua cost time: " ..(os.clock() - t));
	
	-- 2)成员方法的调用
	local v = self.transform.position
	local t = os.clock()
	for i = 1, 200000 do
		v:Normalize()
	end
	print("test2/lua cost time: " ..(os.clock() - t));
	
	-- 3)静态方法调用并返回
	local t = os.clock()
	for i = 1, 200000 do
		v = CS.UnityEngine.Vector3.Normalize(v)
	end
	print("test3/lua cost time: " ..(os.clock() - t));
	
	-- 4)纯属性设置
	local v = self.transform.position
	local t = os.clock()
	for i = 1, 200000 do
		self.transform.position = v
	end
	print("test4/lua cost time: " ..(os.clock() - t));
	
	-- 5)构造valuetype并返回
	local t = os.clock()
	for i = 1, 200000 do
		v = CS.UnityEngine.Vector3(i, i, i)
	end
	print("test5/lua cost time: " ..(os.clock() - t));
	
	-- 6)创建GameObject
	local t = os.clock()
	for i = 1, 200000 do
		local obj = CS.UnityEngine.GameObject();
	end
	print("test6/lua cost time: " ..(os.clock() - t));
end

test(); 