import cv2

img = cv2.imread("image/lena.png")

# convert RGB to YCrCb color space
ycrcb = cv2.cvtColor(img, cv2.COLOR_BGR2YCrCb)

# show the YCrCb image
cv2.imshow("YCrCb", ycrcb)
cv2.waitKey(0)
