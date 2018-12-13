// FUNCTIONS
float GetC(int kx, int ky, int kz)
{
  return sqrt(2/(pow(kx, 2)+pow(ky, 2)+pow(kz, 2)));
}

Matrix CreateCube(int n)
{
  int countVertices = (int)pow(2, 3);
  Matrix cube = new Matrix(countVertices, n);
  cube.SetValue(0, 0, 0);
  cube.SetValue(0, 1, 0);
  cube.SetValue(0, 2, 0);

  cube.SetValue(1, 0, 0);
  cube.SetValue(1, 1, 0);
  cube.SetValue(1, 2, 1);

  cube.SetValue(2, 0, 1);
  cube.SetValue(2, 1, 0);
  cube.SetValue(2, 2, 1);

  cube.SetValue(3, 0, 1);
  cube.SetValue(3, 1, 0);
  cube.SetValue(3, 2, 0);

  cube.SetValue(4, 0, 1);
  cube.SetValue(4, 1, 1);
  cube.SetValue(4, 2, 0);

  cube.SetValue(5, 0, 0);
  cube.SetValue(5, 1, 1);
  cube.SetValue(5, 2, 0);

  cube.SetValue(6, 0, 0);
  cube.SetValue(6, 1, 1);
  cube.SetValue(6, 2, 1);

  cube.SetValue(7, 0, 1);
  cube.SetValue(7, 1, 1);
  cube.SetValue(7, 2, 1);

  for (int i = 0; i < countVertices; i++)
  {
    cube.SetValue(i, n-1, 1);
  }
  return cube;
}

Matrix GetMatrixT(float fix, float fiy)
{
  int n = 4;
  Matrix matrix = new Matrix(n, n);
  matrix.SetValue(0, 0, cos(fiy));
  matrix.SetValue(0, 1, sin(fix)*sin(fiy));
  matrix.SetValue(1, 1, cos(fix));
  matrix.SetValue(2, 0, sin(fiy));
  matrix.SetValue(2, 1, -sin(fix)*cos(fiy));
  matrix.SetValue(3, 3, 1);
  return matrix;
}
