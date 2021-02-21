from PIL import Image
from PIL import ImageFilter
from skimage import morphology
from skimage import io

img_file = "elephant.jpg"
img = Image.open(img_file)
blur_img = img.filter(ImageFilter.GaussianBlur(5))
# blur_img.show()

blur_img = img.filter(ImageFilter.MedianFilter(7))
# blur_img.show()

img_file_text = "some_text.jpg"
img_binary = "some_text_binary.jpg"

# img = Image.open(img_file_text)
# img = img.convert("1")
# img.save(img_binary)
# img.show()

img = io.imread(img_binary)
eroded_img = morphology.binary_erosion(img)
# io.imshow(eroded_img)
# io.show()

dilated_img = morphology.binary_dilation(img)
# io.imshow(dilated_img)
# io.show()

img_file = "elephant.jpg"
img = Image.open(img_file)
img = img.convert("L")
new_img = img.filter(ImageFilter.Kernel((3, 3), [1, 0, -1, 5, 0, -5, 1, 0, 1]))
new_img.show()
