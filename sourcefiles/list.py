import sys
sys.setrecursionlimit(10003)
import time

Nil = None

def cons(x,xs):
    return (x,xs)

def length(xs):
    if xs is Nil:
        return 0
    else:
        return 1+length(xs[1])

def makelist(i,xs):
    if(i==0):
        return xs
    else:
        return makelist(i-1,cons(i,xs))

lst = makelist(10000,Nil)
for i in range(0,1000):
    start = time.clock()
    val = length(lst)
    end = time.clock()
    print(end-start)
