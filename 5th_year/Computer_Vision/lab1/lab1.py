from skimage import io, color, draw
from skimage import data
from PIL import Image
from PIL import ImageEnhance
import numpy as np

img_file = "elephant.jpg"
img = Image.open(img_file)
img.show()

dim = (100, 100, 400, 400)
crop_img = img.crop(dim)
crop_img.show()

grayscale = img.convert("L")
grayscale.show()

resize_img = img.resize((200, 200))
resize_img.show()

rotate_img = img.rotate(90)
rotate_img.show()

enhancer = ImageEnhance.Brightness(img)
enhancer.enhance(2).show()

enhancer = ImageEnhance.Contrast(img)
enhancer.enhance(2).show()

pixel = img.getpixel((100, 100))
print(pixel)

img.putpixel((100, 100), (20, 230, 145))
pixel = img.getpixel((100, 100))
print(pixel)

img = io.imread(img_file)
io.imshow(img)
io.show()

gray = color.rgb2gray(img)
io.imshow(gray)
io.show()

img = np.zeros((100, 100), dtype=np.uint8)
x, y = draw.circle(50, 50, 10)
img[x, y] = 1
io.imshow(img)
io.show()

img = np.zeros((100, 100), dtype=np.uint8)
x, y = draw.ellipse(50, 50, 10, 20)
img[x, y] = 1
io.imshow(img)
io.show()

img = np.zeros((100, 100), dtype=np.uint8)
r = np.array([10, 25, 80, 50])
c = np.array([10, 60, 40, 10])
x, y = draw.polygon(r, c)
img[x, y] = 1
io.imshow(img)
io.show()
