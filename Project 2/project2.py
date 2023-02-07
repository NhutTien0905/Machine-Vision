import cv2
import numpy as np

img = cv2.imread("D:/University/Semester_2_2nd/Machine Vision/image/lena.jpg")

red = np.zeros((img.shape[0],img.shape[1],3),np.uint8)
green = np.zeros((img.shape[0],img.shape[1],3),np.uint8)
blue = np.zeros((img.shape[0],img.shape[1],3),np.uint8)

red[:,:,2] = img[:,:,2]
green[:,:,1] = img[:,:,1]
blue[:,:,0] = img[:,:,0]

cv2.imshow("img",img)
cv2.imshow("red",red)
cv2.imshow("green",green)
cv2.imshow("blue",blue)
cv2.waitKey()