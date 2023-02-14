import cv2
import numpy as np
def empty(a):
    threshold=a
    binaryLum=np.where(lumi>threshold,255,0)
    cv2.imshow("binary Luminance",binaryLum.astype(np.uint8))
    binaryLight=np.where(light>threshold,255,0)
    cv2.imshow("binary Light",binaryLight.astype(np.uint8))
    binaryAve=np.where(averRage>threshold,255,0)
    cv2.imshow("binary Ave",binaryAve.astype(np.uint8))

def Average(img):
    averRage = np.sum(img[:,:,:],axis = 2,keepdims=True)/3
    return averRage.astype(np.uint8)

def Lightness(img):
    minn = np.amin(img[:,:,:],axis = 2,keepdims=True)
    maxx = np.amax(img[:,:,:],axis = 2,keepdims=True)

    lightness = np.sum(np.array([minn,maxx]),axis = 0)/2
    return lightness.astype(np.uint8)

def Luminance(img):
    red = img[:,:,2]
    green = img[:,:,1]
    blue = img[:,:,0]

    luminance = np.sum(np.array([0.2126*red, 0.7152*green, 0.0722*blue]),axis = 0)
    luminance = np.expand_dims(luminance,axis=2)
    return luminance.astype(np.uint8)

cv2.namedWindow("title_window")
cv2.createTrackbar("Threshold", "title_window" , 0, 255, empty)
img = cv2.imread("C:/Users/Admin/Downloads/Lenna_(test_image).jpg")
# cv2.imshow("Original",img)

#average
averRage=Average(img)
# cv2.imshow("Average",averRage)


# Lightness method
light = Lightness(img)
# cv2.imshow("lightness",light)#lightness

# Luminance method

lumi=Luminance(img)

# cv2.imshow("luminance",lumi)
cv2.waitKey()
#binary

