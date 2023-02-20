import cv2
from PIL import Image
import numpy as np
import matplotlib.pyplot as plt

filehinh=r'D:/University/Semester_2_2nd/Machine Vision/image/bird_small.jpg'
img=cv2.imread(filehinh,cv2.IMREAD_COLOR)
imgPIL=Image.open(filehinh)


def TinhHistogram(imgPIL):
    hisR=np.zeros(256)
    hisG=np.zeros(256)
    hisB=np.zeros(256)

    w=imgPIL.size[0]
    h=imgPIL.size[1]

    for x in range(w):
        for y in range(h):

            gR,gG,gB=imgPIL.getpixel((x,y))

            hisR[gR]+=1
            hisG[gG]+=1
            hisB[gB]+=1

    return hisR,hisG,hisB

## Ve bieu do
def VeBieuDoHistogram(hisR,hisG,hisB):
    w=5
    h=4
    plt.figure('Bieu do anh mau RGB',figsize=(((w,h))),dpi=100)
    trucX=np.zeros(256)
    trucX=np.linspace(0,256,256)
    plt.plot(trucX,hisR,color='red')
    plt.plot(trucX,hisG,color='green')
    plt.plot(trucX,hisB,color='blue')
    plt.title('Bieu do Histogram')
    plt.xlabel('Gia tri diem anh')
    plt.ylabel('So diem cung gia tri')
    plt.show()


hisR,hisG,hisB=TinhHistogram(imgPIL)
cv2.imshow('Anh mau RGB goc',img)
VeBieuDoHistogram(hisR,hisG,hisB)
cv2.waitKey(0)
cv2.destroyAllWindows()
