local Log = print;
local TIMES = 100000;
local UNIT_MS = 1000;

function test(self)
	-- 1)属性的读取和设置
	local t = os.clock()
	for i = 1, TIMES do
		local v = self.transform.position
		self.transform.position = v
	end
	Log("test1/lua cost time: " ..(os.clock() - t) * UNIT_MS);
	-- 2)成员方法的调用
	local v = self.transform.position
	local t = os.clock()
	for i = 1, TIMES do
		v:Normalize()
	end
	Log("test2/lua cost time: " ..(os.clock() - t) * UNIT_MS);
	-- 3)静态方法调用并返回
	local t = os.clock()
	for i = 1, TIMES do
		v = Vector3.Normalize(v)
	end
	Log("test3/lua cost time: " ..(os.clock() - t) * UNIT_MS);
	-- 4)纯属性设置
	local v = self.transform.position
	local t = os.clock()
	for i = 1, TIMES do
		self.transform.position = v
	end
	Log("test4/lua cost time: " ..(os.clock() - t) * UNIT_MS);
	-- 5)构造valuetype并返回
	local t = os.clock()
	for i = 1, TIMES do
		v = Vector3(i, i, i)
	end
	Log("test5/lua cost time: " ..(os.clock() - t) * UNIT_MS);
	-- 6)创建GameObject
	local t = os.clock()
	for i = 1, TIMES do
		local obj = UnityEngine.GameObject.New();
	end
	Log("test6/lua cost time: " ..(os.clock() - t) * UNIT_MS);
end
