m = io.read("*n")
n = io.read("*n")

for i = m, n - 1, 1 do
    if (i % 2 == 0) then
        print(i)
    end
end

--[[別解
for i = m + (m % 2), n - 1, 2 do
    print(i)
end
]]