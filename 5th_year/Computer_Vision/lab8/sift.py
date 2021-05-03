import cv2

image = cv2.imread('image.jpg')
gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
sift_obj = cv2.xfeatures2d.SIFT_create()
keypoints = sift_obj.detect(gray, None)
img = cv2.drawKeypoints(gray, keypoints, image)
cv2.imshow("image", img)
cv2.waitKey(0)
cv2.destroyAllWindows()
