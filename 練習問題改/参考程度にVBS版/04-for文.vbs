dim m, n

m = InputBox("")
n = InputBox("")

for i = m to n - 1
    if i mod 2 = 0 then
        MsgBox(i)
    end if
next

'別解
'for i = m + (m mod 2) to n - 1 step 2
'    MsgBox(i)
'next
