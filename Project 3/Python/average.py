import cv2
import numpy as np

img = cv2.imread("D:/University/Semester_2_2nd/Machine Vision/image/lena.jpg")
zeroImg = np.zeros((img.shape[0],img.shape[1],3),dtype=np.uint8)

# Average method
zeroImg[:,:,:] = np.sum(img[:,:,:],axis = 2,keepdims=True)/3

cv2.imshow("average",zeroImg)
cv2.imshow("img",img)

# Lightness method
minn = np.amin(img[:,:,:],axis = 2,keepdims=True)
maxx = np.amax(img[:,:,:],axis = 2,keepdims=True)

lightness = np.sum(np.array([minn,maxx]),axis = 0)/2
print(lightness.shape)
zeroImg[:,:,:] = lightness[:,:,:]

cv2.imshow("lightness",zeroImg)

# Luminance method
red = img[:,:,2]
green = img[:,:,1]
blue = img[:,:,0]

luminance = np.sum(np.array([0.2126*red, 0.7152*green, 0.0722*blue]),axis = 0)
luminance = np.expand_dims(luminance,axis=2)
zeroImg[:,:,:] = luminance[:,:,:]

cv2.imshow("luminance",zeroImg)
cv2.waitKey()