import cv2
import numpy as np

img = cv2.imread("image/lena.png")
zeroImg = np.zeros(img.shape,dtype=np.uint8)

r = img[:,:,2]
g = img[:,:,1]
b = img[:,:,0]

y = 16 + (65.738*r + 129.057*g + 25.064*b)/256
cb = 128 - (37.945*r + 74.494*g - 112.439*b)/256
cr = 128 + (112.439*r - 94.154*g - 18.285*b)/256

zeroImg[:,:,:] = np.expand_dims(y,axis = 2)
cv2.imshow("Y",zeroImg)
zeroImg[:,:,:] = np.expand_dims(cb,axis = 2)
cv2.imshow("Cb",zeroImg)
zeroImg[:,:,:] = np.expand_dims(cr,axis = 2)
cv2.imshow("Cr",zeroImg)
zeroImg[:,:,:] = np.dstack((cr,cb,y))
cv2.imshow("YCrCb",zeroImg)
cv2.waitKey()