import time

lst = [1]*1000000

for i in range(0,1000):
    start=time.clock()
    length=lst.count(1)
    end=time.clock()
    print(end-start)
