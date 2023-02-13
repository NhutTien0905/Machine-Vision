import cv2
import numpy as np

img = cv2.imread("D:/University/Semester_2_2nd/Machine Vision/image/lena.jpg")
zeroImg = np.zeros(img.shape,dtype=np.uint8)

def convertColor(img):
    oneImg = np.ones((img.shape[0],img.shape[1]),dtype=np.uint8)

    r = img[:,:,2]/255
    g = img[:,:,1]/255
    b = img[:,:,0]/255

    c = oneImg - r
    m = oneImg - g
    y = oneImg - b
    k = np.amin(img,axis=2)

    return c,m,y,k

c, m, y, k = convertColor(img)
cyan = img.copy()
magenta = img.copy()
yellow = img.copy()

cyan[:,:,2] = c
magenta[:,:,1] = m
yellow[:,:,0] = y

cv2.imshow("Image",img)
cv2.imshow("Cyan",cyan)
cv2.imshow("Magenta",magenta)
cv2.imshow("Yellow",yellow)
cv2.imshow("Black",k)

cv2.waitKey()
cv2.destroyAllWindows()