#! /usr/bin/python3
def collatz(i):
    ret = [i]
    while i != 1:
        i = 3 * i + 1 if i & 1 else i // 2
        ret.append(i)
    return ret

for i in range(1,10001):
    print(collatz(i))