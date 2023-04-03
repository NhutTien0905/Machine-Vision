import numpy as np
ko = np.zeros((3,3))
ko = np.where(ko==0,np.nan,1)
print(ko)
ko = np.nan_to_num(ko,nan = 255)
# ko = np.where(ko == np.nan,1,0)
print(ko)