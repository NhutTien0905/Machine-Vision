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
    rangee = lengthImg - lengthMask
    result = np.zeros((img.shape[0] + 2*padSize, img.shape[1] + 2*padSize))
    for i in range(rangee):
        for j in range(rangee):
            pieceImg = nImg[i:i+lengthMask,j:j+lengthMask]
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

def empty(a):
    threshold=a
    binary=np.where(newImg>threshold,255,0)
    cv2.imshow("Sobel",binary.astype(np.uint8))

def Luminance(img):
    red = img[:,:,2]
    green = img[:,:,1]
    blue = img[:,:,0]
    luminance = np.sum(np.array([0.2126*red, 0.7152*green, 0.0722*blue]),axis = 0)
    luminance = np.expand_dims(luminance,axis=2)
    return luminance.astype(np.uint8)

def findEdge(img,mask):
    nImg = np.zeros_like(img)
    for i in range(img.shape[2]):
        frame = convolution(img[:,:,i],mask,"same")
        nImg[:,:,i] = frame
    return nImg

img = cv2.imread("image/lena.png")
maskX = np.array([[-1,-2,-1],
                [0,0,0],
                [1,2,1]])

maskY = np.array([[-1,0,1],
                [-2,0,2],
                [-1,0,1]])

cv2.namedWindow("org")
cv2.createTrackbar("Threshold", "org" , 0, 255, empty)

grayImg = Luminance(img)
newImgX = findEdge(grayImg,maskX)
newImgY = findEdge(grayImg,maskY)
newImg = np.abs(newImgY)+np.abs(newImgX)

cv2.imshow("org",img)
cv2.waitKey()