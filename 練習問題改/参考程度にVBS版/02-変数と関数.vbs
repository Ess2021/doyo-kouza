function Ave(a, b, c)
    dim _sum, _ave
    _sum = a + b + c
    _ave = _sum / 3
    Ave = _ave
end function

dim a, b, c, res

a = InputBox()
b = InputBox()
c = InputBox()

res = Ave(a, b, c)

MsgBox(res)
