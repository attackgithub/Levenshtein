from numba import cuda
from numba import *
import numpy as np
from pylab import imshow, show
from timeit import default_timer as timer

def leven_dist(A, B):
    i = j = 0
    #metric = np.zeros([A.shape[0]+1, B.shape[0]+1], dtype=np.int)
    h = A.shape[0]+1
    w = B.shape[0]+1
    metric = [[0 for x in range(w)] for y in range(h)] 

    #start = timer()
    for i in range(0, len(A)+1):
        metric[i][0] = i
    for j in range(0, len(B)+1):
        metric[0][j] = j

    for i in range(1, len(A)+1):    
        for j in range(1, len(B)+1):
            if A[i-1] == B[j-1]:
                cost = 0
            else:
                cost = 1
            metric[i][j] = min(metric[i-1][j]+1, metric[i][j-1]+1, metric[i-1][j-1] + cost)

    #vectoradd_time = timer() - start
    #print("Time:%f" % vectoradd_time)
    #print(metric)
    return metric[len(A)][len(B)]   

@autojit
def leven_jit(word, line, metric_values):
    
    wordLen = len(word)
    maxPos = len(line)-wordLen+1

    for i in range(maxPos):
        metric_values[i] = leven_dist(word, line[i:i+wordLen])