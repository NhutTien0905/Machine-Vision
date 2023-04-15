import cv2
import numpy as np

def convolution(img,mask,mode):
    dictMode = {
        "valid": -1,
        "same": 0,
        "full": 1
    }
    padSize = dictMode[mode]
    nImg = np.pad(img,padSize+1)
    lengthMask = len(mask)
    lengthImg = len(nImg)
    result = np.zeros((img.shape[0] + 2*padSize, img.shape[1] + 2*padSize))
    for i in range(1,lengthImg-1):
        for j in range(1,lengthImg-1):
            pieceImg = nImg[i-1:i+2,j-1:j+2]
            s = 0
            for k in range(lengthMask):
                for t in range(lengthMask):
                    s = s + pieceImg[k][t]*mask[k][t]
            if s < 0:
                s = 0
            elif s > 255:
                s = 255
            result[i-1,j-1] = s
    return result

def findEdge(img,mask):
    nImg = np.zeros_like(img)
    for i in range(img.shape[2]):
        frame = convolution(img[:,:,i],mask,"same")
        nImg[:,:,i] = frame
    return nImg

def calRateOfChange(rgbX, rgbY):
    gxx = np.sum(rgbX**2, axis=2)
    gyy = np.sum(rgbY**2, axis=2)
    gxy = np.sum(rgbX*rgbY, axis=2)
    theta = 0.5*np.arctan2(2*gxy,(gxx-gyy))
    F = np.sqrt(0.5*((gxx+gyy) + (gxx-gyy)*np.cos(2*theta)+2*gxy*np.sin(2*theta)))
    return F.astype(np.uint8)

def empty(a):
    threshold=a
    binary = calRateOfChange(rgbX,rgbY)
    binary=np.where(binary>=threshold,255,0)
    cv2.imshow("Sobel",binary.astype(np.uint8))

img = cv2.imread("image/lena.png")
maskX = np.array([[-1,-2,-1],
                [0,0,0],
                [1,2,1]])

maskY = np.array([[-1,0,1],
                [-2,0,2],
                [-1,0,1]])

cv2.namedWindow("org")
cv2.createTrackbar("Threshold", "org" , 0, 255, empty)

rgbX = findEdge(img,maskX).astype(np.float64)
rgbY = findEdge(img,maskY).astype(np.float64)
cv2.imshow("org",img)
cv2.waitKey()
