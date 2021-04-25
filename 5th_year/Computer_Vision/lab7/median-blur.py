import cv2

img = cv2.imread("image.jpg")
new_img = cv2.medianBlur(img, 5)
cv2.imshow("median_blur", new_img)
cv2.waitKey(0)
cv2.destroyAllWindows()
