import cv2

img = cv2.imread("image.jpg")
r, c = img.shape[:2]
new_img = cv2.resize(img, (2*r, 2*c), interpolation=cv2.INTER_CUBIC)
cv2.imshow("resize", new_img)
cv2.waitKey(0)
cv2.destroyAllWindows()
