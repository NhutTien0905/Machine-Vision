import cv2
from PIL import Image
import numpy as np
import matplotlib.pyplot as plt

def TinhHistogram(HinhXamPIL):
    his=np.zeros(256)
    w=HinhXamPIL.size[0]
    h=HinhXamPIL.size[1]
    for x in range(w):
        for y in range(h):
            gR,gG,gB=HinhXamPIL.getpixel((x,y))
            his[gR]+=1
    return his

def ChuyenDoiAnhMauRGBSangAnhXamLuminance(imgPIL):
    average=Image.new(imgPIL.mode,imgPIL.size)
    width=average.size[0]
    height=average.size[1]
    for x in range(width):
        for y in range(height):
            R,G,B=imgPIL.getpixel((x,y))
            gray=np.uint8(0.2126*R+0.7152*G+0.0722*B)
            average.putpixel((x,y),(gray,gray,gray))
    return average

def VeBieuDoHistogram(his):
	w=5
	h=4
	plt.figure('Bieu do Histogram anh xam',figsize=(((w,h))),dpi=100)
	trucX=np.zeros(256)
	trucX=np.linspace(0,256,256)
	plt.plot(trucX,his,color='orange')
	plt.title('Bieu do Histogram')
	plt.xlabel('Gia tri muc xam')
	plt.ylabel('So diem cung gia tri muc xam')
	plt.show()


filehinh="D:/University/Semester_2_2nd/Machine Vision/image/lena.jpg"

imgPIL=Image.open(filehinh)
HinhxamPIL=ChuyenDoiAnhMauRGBSangAnhXamLuminance(imgPIL)
his=TinhHistogram(HinhxamPIL)
HinhxamCV=np.array(HinhxamPIL)
cv2.imshow('Anh muc xam',HinhxamCV)
VeBieuDoHistogram(his)

cv2.waitKey(0)

