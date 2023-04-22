import matplotlib.pyplot as plt
import cv2
import numpy as np

img = cv2.imread("image/smarties.png",cv2.IMREAD_GRAYSCALE)
_,mask = cv2.threshold(img,220,255,cv2.THRESH_BINARY_INV)

# xem như cái mask nền để xóa nhiễu ảnh
kernel = np.ones((5,5),np.uint8)

# dãn đối tượng đang xét ra thêm dựa trên kernel (pixel 1 khi có ít nhất 1 pixel trong kernel là 1)
dilation = cv2.dilate(mask,kernel,iterations = 2)
# thu hẹp đối tượng đang xét dựa tren kernel (pixel là 1 khi tất cả pixel kernal là 1)
erosion = cv2.erode(mask,kernel,iterations = 1)
# là erosion khác nhưng dựa trên dilation chuyên dùng để xóa nhiễu bên ngoài đối tượng
opening = cv2.morphologyEx(mask,cv2.MORPH_OPEN,kernel)
# là dilation dựa trên erosion dùng xóa chấm đen nhiễu bên trong đối tượng
closing = cv2.morphologyEx(mask,cv2.MORPH_CLOSE,kernel)
# tạo ra 1 viền cho đối tượng đang xét ( khác với dilation và erosion)
mg = cv2.morphologyEx(mask,cv2.MORPH_GRADIENT,kernel)
# tạo ra sự khác nhau giữa source với opening
th = cv2.morphologyEx(mask,cv2.MORPH_TOPHAT,kernel)


titles = ["img","mask","dilation","erosion","opening","closing","mg","th"]
imgs = [img,mask,dilation,erosion,opening,closing,mg,th]

plt.figure(figsize=(10,8))
for i in range(len(titles)):
    plt.subplot(4,4,i+1)
    plt.imshow(imgs[i],"gray")
    plt.title(titles[i])
    plt.xticks([])
    plt.yticks([])
    plt.tight_layout()

plt.show()