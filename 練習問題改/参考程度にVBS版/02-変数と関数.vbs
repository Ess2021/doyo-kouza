function Ave(x, y, z)
    dim sum, ave_
    sum = x + y + z
    ave_ = sum / 3
    Ave = ave_
end function

dim a, b, c, res

a = InputBox("")
b = InputBox("")
c = InputBox("")

res = Ave(a, b, c)

MsgBox(res)
