import cv2

img = cv2.imread("image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
x_edges = cv2.Sobel(gray, -1, 1, 0, ksize=5)
y_edges = cv2.Sobel(gray, -1, 0, 1, ksize=5)
x_y_edges = cv2.Sobel(gray, -1, 1, 1, ksize=5)

cv2.imshow("xedges", x_edges)
cv2.imshow("yedges", y_edges)
cv2.imshow("x_y_edges", x_y_edges)

cv2.waitKey(0)
cv2.destroyAllWindows()
