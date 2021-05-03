
import cv2
import random

image = cv2.imread('image.jpg')
image_rot = cv2.imread('image_rot.jpg')
gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
gray_rot = cv2.cvtColor(image_rot, cv2.COLOR_BGR2GRAY)
sift = cv2.xfeatures2d.SIFT_create()
kp, desc = sift.detectAndCompute(gray, None)
kp_rot, desc_rot = sift.detectAndCompute(gray_rot, None)

# BFMatcher with default params
bf = cv2.BFMatcher()
matches = bf.knnMatch(desc, desc_rot, k=2)

# Apply ratio test
good = []
for m, n in matches:
    if m.distance < 0.4*n.distance:
        good.append([m])

# Shuffle the matched keypoints
random.shuffle(good)
# cv2.drawMatchesKnn expects list of lists as matches.
image_match = cv2.drawMatchesKnn(
    image, kp, image_rot, kp_rot, good[:10], flags=2, outImg=None)

cv2.imshow("sift_matches", image_match)
cv2.waitKey(0)
cv2.destroyAllWindows()
