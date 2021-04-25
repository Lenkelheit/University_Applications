import cv2

img = cv2.imread("image.jpg")
img_crop = img[0:200, 150:350]
cv2.imshow("crop", img_crop)
cv2.waitKey(0)
cv2.destroyAllWindows()
