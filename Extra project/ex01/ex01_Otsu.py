import cv2

# Đọc ảnh đầu vào
img = cv2.imread("image/lena.png")

# Chuyển ảnh sang dạng grayscale
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Vẽ histogram của ảnh grayscale
hist = cv2.calcHist([gray], [0], None, [256], [0, 256])

# Tìm ngưỡng phân đoạn bằng phương pháp Otsu
ret, thresh = cv2.threshold(gray, 0, 255, cv2.THRESH_BINARY+cv2.THRESH_OTSU)

# Hiển thị ảnh gốc và ảnh đã phân đoạn
cv2.imshow("Input Image", img)
cv2.imshow("Segmented Image", thresh)
cv2.waitKey(0)
cv2.destroyAllWindows()
