import cv2
import numpy as np
# from scipy.signal import convolve2d

img = cv2.imread("image/lena.jpg")
mask = np.array([[0,-1,0],
                 [-1,4,-1],
                 [0,-1,0]])

# use convolve2d in scipy #
# result = np.zeros_like(img)
# result[:,:,0] = convolve2d(img[:,:,0],mask,"same") + img[:,:,0]
# result[:,:,1] = convolve2d(img[:,:,1],mask,"same") + img[:,:,1]
# result[:,:,2] = convolve2d(img[:,:,2],mask,"same") + img[:,:,2]

def convolution(img,mask,mode):
    dictMode = {
        "valid": -1,
        "same": 0,
        "full": 1
    }
    padSize = dictMode[mode]
    print(img.shape)
    nImg = np.pad(img,padSize+1)
    lengthMask = len(mask)
    lengthImg = len(nImg)
    rangee = lengthImg - lengthMask
    result = np.zeros((img.shape[0] + 2*padSize, img.shape[1] + 2*padSize))
    print(result.shape)
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

newImg = np.zeros_like(img)
# newImg = np.zeros((514,514,3))
for i in range(img.shape[2]):
    newImg[:,:,i] = convolution(img[:,:,i],mask,"same") + img[:,:,i]

cv2.imshow("org",img)
cv2.imshow("smooth",newImg)
cv2.waitKey()