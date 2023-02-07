import cv2
import numpy as np

img = cv2.imread("D:/University/Semester_2_2nd/Machine Vision/image/lena.jpg")
zeroImg = np.zeros((img.shape[0],img.shape[1],3),dtype=np.uint8)

minn = np.amin(img[:,:,:],axis = 2,keepdims=True)
maxx = np.amax(img[:,:,:],axis = 2,keepdims=True)

lightness = np.sum(np.array([minn,maxx]),axis = 0)/2
print(lightness.shape)
zeroImg[:,:,:] = lightness[:,:,:]

cv2.imshow("lightness",zeroImg)
cv2.waitKey()