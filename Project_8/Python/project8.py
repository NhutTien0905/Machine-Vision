import cv2
import numpy as np

img = cv2.imread("image/lena.png")
zeroImg = np.zeros(img.shape,dtype=np.uint8)

red = img[:,:,2].astype(np.float16)
green = img[:,:,1].astype(np.float16)
blue = img[:,:,0].astype(np.float16)

# HUE
frameH = np.zeros((img.shape[0],img.shape[1]),dtype=np.uint8)
t = (red - green) + (red - blue)
m = np.sqrt((red - green)**2 + (red - blue)*(green - blue))
theta = np.arccos(0.5*t/m)
degree = 180*(theta/np.pi)
frameH = np.where(blue > green, 360 - degree, degree)

# SATURATION
frameS = np.zeros((img.shape[0],img.shape[1]),dtype=np.uint8)
frameS = 255*(1 - 3*(np.min(img,axis = 2)/np.sum(img,axis=2)))

# VALUE
frameV = np.max(img,axis=2)

zeroImg[:,:,2] = frameH
zeroImg[:,:,1] = frameS
zeroImg[:,:,0] = frameV

cv2.imshow("SATURATION",frameS.astype(np.uint8))
cv2.imshow("VALUE",frameV.astype(np.uint8))
cv2.imshow("HUE",frameH.astype(np.uint8))
cv2.imshow("HSV",zeroImg)
cv2.waitKey()