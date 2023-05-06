import cv2
import numpy as np
import matplotlib.pyplot as plt

img = cv2.imread("image/lena.png",0)

# tạo pyramid gauss cho ảnh 1
G1 = img.copy()
gp_img = [G1]
for i in range(4):
	G1 = cv2.pyrDown(G1)
	gp_img.append(G1)
	
# tạo Laplacian pyramid cho ảnh 1
lp1 = [gp_img[-1]]
for i in range(3,0,-1):
	size = (gp_img[i-1].shape[1],gp_img[i-1].shape[0])
	ge = cv2.pyrUp(gp_img[i],dstsize = size)
	l = cv2.subtract(gp_img[i-1],ge)
	lp1.append(l)

# tái tạo
plt.figure(figsize=(10,5))
for i in range(len(lp1)):
    plt.subplot(1,len(lp1),i+1)
    plt.axis("off")
    plt.title(f"{lp1[i].shape}")
    plt.imshow(lp1[i],cmap="gray")
    plt.tight_layout()
plt.show()