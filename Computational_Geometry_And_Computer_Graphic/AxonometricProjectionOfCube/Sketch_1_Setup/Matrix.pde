class Matrix
{
  // FIELDS
  private float[][] matrix;
  private int numberRows, numberColumns;
  
  // CONSTRUCTORS
  Matrix(int n, int m)
  {
    numberRows = n;
    numberColumns = m;
    matrix = new float[n][m];
  }
  
  // METHODS
  float GetValue(int first, int second)
  {
    return matrix[first][second];
  }
  
  void SetValue(int first, int second, float value)
  {
    matrix[first][second] = value;
  }
  
  Matrix MultiplyTo(Matrix otherMatrix)
  {
    Matrix result = null;
    if (this.numberColumns == otherMatrix.numberRows)
    {
      result = new Matrix(this.numberRows, otherMatrix.numberColumns);
      for (int i = 0; i<this.numberRows; i++)
      {
        for (int j=0; j<otherMatrix.numberColumns; j++)
        {
          for (int k=0; k<this.numberColumns; k++)
          {
            result.matrix[i][j]+=this.matrix[i][k]*otherMatrix.matrix[k][j];
          }
        }
      }
    }
    return result;
  }
}
