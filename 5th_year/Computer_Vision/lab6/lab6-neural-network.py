from sklearn.datasets import fetch_openml, load_digits
from sklearn.neural_network import MLPClassifier
from sklearn.preprocessing import normalize
from sklearn.model_selection import train_test_split
from skimage import io, color, feature, transform
from PIL import Image

# Get MNIST Dataset
print('Getting MNIST Data...')
mnist = fetch_openml("mnist_784", as_frame=False)
print('MNIST Data downloaded!')

images = mnist.data
labels = mnist.target

# Preprocess the images
images = normalize(images, norm='l2')

# Split the data into training set and test set
images_train, images_test, labels_train, labels_test = train_test_split(
    images, labels, test_size=0.25, random_state=17)

# Setup the neural network that we want to train on
nn = MLPClassifier(hidden_layer_sizes=(100, 100, 100), max_iter=20, solver='sgd',
                   learning_rate_init=0.01, verbose=True)

# Start training the network
print('NN Training started...')
nn.fit(images_train, labels_train)
print('NN Training completed!')

digit_img = io.imread('digit-6.png')
digit_img = transform.resize(digit_img, (28, 28), mode="wrap")
digit_img = color.rgb2gray(digit_img)
digit_img = digit_img.reshape(1, -1)

ownDigitImage = normalize(digit_img, norm='l2')

prediction = nn.predict(ownDigitImage)

print(prediction)

# Evaluate the performance of the neural network on test data
print('Network Performance: %f' % nn.score(images_test, labels_test))
