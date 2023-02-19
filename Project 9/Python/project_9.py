import cv2
import numpy as np

img = cv2.imread("image/lena.jpg")
img_rgb = cv2.cvtColor(img,cv2.COLOR_BGR2RGB)
zero_img = np.zeros(img.shape,dtype=np.uint8)
transfer_matrix = np.array([[0.4124564,0.3575761,0.1804375],
                            [0.2126729,0.7151522,0.0721750],
                            [0.0193339,0.1191920,0.9503041]])

for i in range(img.shape[0]):
    for j in range(img.shape[1]):
        xyz = np.matmul(transfer_matrix,img_rgb[i][j])
        zero_img[i][j] = xyz

cv2.imshow("xyz",zero_img)
cv2.imshow("x",zero_img[:,:,0])
cv2.imshow("y",zero_img[:,:,1])
cv2.imshow("z",zero_img[:,:,2])
cv2.waitKey()