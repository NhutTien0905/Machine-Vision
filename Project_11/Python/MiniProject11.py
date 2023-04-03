import cv2
import numpy as np

img = cv2.imread("image/lena.png")
zeroImg = np.zeros(img.shape,dtype=np.uint8)
mask_sizes = [3, 5, 7, 9]
for size in mask_sizes:
    mask = np.ones ((size, size), np.float32) / (size**2)
    smoothed_img = cv2.filter2D(img, -1, mask)
    cv2.imshow('Smoothed with ' + str(size) + 'x' + str(size) + 'mask', smoothed_img)

cv2.waitKey(0)
cv2.destroyAllWindows()