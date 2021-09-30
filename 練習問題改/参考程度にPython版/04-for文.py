m = int(input())
n = int(input())

for i in range (m, n, 1):
    if i % 2 == 0:
        print(i)

""" 別解
for i in range (m + (m % 2), n, 2):
    print(i)
"""