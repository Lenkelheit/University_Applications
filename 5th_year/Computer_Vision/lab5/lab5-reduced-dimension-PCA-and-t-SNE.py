import numpy as np
import matplotlib.pyplot as plt
from sklearn import datasets, decomposition, manifold


def plot_digits(X, title=None):
    x_min, x_max = np.min(X, 0), np.max(X, 0)
    X = (X - x_min) / (x_max - x_min)

    plt.figure()

    for i in range(X.shape[0]):
        plt.text(X[i, 0], X[i, 1], str(digits.target[i]),
                 color=plt.cm.Set1(y[i] / 10.),
                 fontdict={'weight': 'bold', 'size': 9})

    plt.xticks([]), plt.yticks([])
    if title is not None:
        plt.title(title)


digits = datasets.load_digits(n_class=6)
X = digits.data
y = digits.target

X_pca = decomposition.PCA(n_components=2).fit_transform(X)
plot_digits(X_pca, "PCA")

X_tsne = manifold.TSNE(n_components=2, init='pca', random_state=0).fit_transform(X)
plot_digits(X_tsne, "t-SNE")

plt.show()
