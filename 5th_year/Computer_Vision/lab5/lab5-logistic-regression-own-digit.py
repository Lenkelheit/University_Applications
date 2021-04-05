from sklearn import datasets, metrics
from sklearn.linear_model import LogisticRegression
from sklearn.preprocessing import StandardScaler
from skimage import io, color, feature, transform
from skimage.filters import sobel

mnist = datasets.load_digits()
images = mnist.images
data_size = len(images)

# Preprocessing images
images = images.reshape(len(images), -1)
labels = mnist.target

# Initialize Logistic Regression
LR_classifier = LogisticRegression(
    C=0.01, penalty='l1', solver='liblinear', tol=0.01)

# Training the data on only 75% of the dataset. Rest of the 25% will be used in testing the Logistic Regression
LR_classifier.fit(images[:int((data_size / 4) * 3)],
                  labels[:int((data_size / 4) * 3)])

# Load a custom image
digit_img = io.imread('digit-4.png')

# Convert image to grayscale
digit_img = color.rgb2gray(digit_img)

# Resize the image to 8x8
digit_img = transform.resize(digit_img, (8, 8), mode="wrap")

# Run edge detection on the image
digit_img = sobel(digit_img)

io.imshow(digit_img)
io.show()

digit_img = digit_img.reshape(1, -1)

# Testing the data
prediction = LR_classifier.predict(digit_img)

print(prediction)
