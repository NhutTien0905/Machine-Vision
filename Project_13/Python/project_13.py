import cv2
import numpy as np

def nothing(x):
    segmented = segmentColor(copiedImg,x)
    cv2.imshow("Segmented Image",segmented.astype(np.uint8))

def segmentColor(img,distance):
    segmented = np.zeros_like(img)
    for i in range(len(img)):
        for j in range(len(img)):
            value = img[i][j]
            relativeDis = np.sqrt(np.sum((value - avgColor)**2))
            if relativeDis <= distance:
                segmented[i][j] = [255,255,255]
            else:
                segmented[i][j] = img[i][j]
    return segmented

img = cv2.imread("image/lena.png")
copiedImg = img.copy()
img = img.astype(np.uint16)
coordinate1 = [80,400]
coordinate2 = [150,500]

avgColor = [0]*3
avgColor[0] = np.mean(img[80:150,400:500,2])
avgColor[1] = np.mean(img[80:150,400:500,1])
avgColor[2] = np.mean(img[80:150,400:500,0])

cv2.namedWindow('Image')
cv2.createTrackbar('Distance', 'Image', 0, 255, nothing)
cv2.rectangle(img,coordinate1,coordinate2,5,thickness=2)
cv2.imshow("Image",img.astype(np.uint8))
cv2.waitKey()