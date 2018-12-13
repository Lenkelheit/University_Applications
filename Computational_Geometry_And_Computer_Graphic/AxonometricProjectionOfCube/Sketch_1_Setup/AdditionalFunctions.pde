// FUNCTIONS
void DrawCentersOfEllipses(Matrix matCenterPoints2D)
{
  stroke(color(255, 0, 0));
  for (int i=0; i<matCenterPoints2D.numberRows; ++i)
  {
    point(matCenterPoints2D.GetValue(i, 0), -matCenterPoints2D.GetValue(i, 1));
  }
}

void FillMatrixCirclePoints(Matrix[] circlePoints3D, Matrix matCenterPoints3D, 
  float radius)
{
  int numElem = 32;
  for (int i=0; i<circlePoints3D.length; i++)
  {
    circlePoints3D[i] = new Matrix(numElem, 4);
  }
  float angle = 0;
  for (int k=0; k<numElem; k++)
  {
    if (angle>TWO_PI)
    {
      break;
    }
    float elemX = matCenterPoints3D.GetValue(0, 0)+sin(angle)*radius;
    float elemY = matCenterPoints3D.GetValue(0, 1);
    float elemZ = matCenterPoints3D.GetValue(0, 2)+cos(angle)*radius;

    circlePoints3D[0].SetValue(k, 0, elemX);
    circlePoints3D[0].SetValue(k, 1, elemY);
    circlePoints3D[0].SetValue(k, 2, elemZ);

    angle+=PI/16;
  }

  angle = 0;
  for (int k=0; k<numElem; k++)
  {
    if (angle>TWO_PI)
    {
      break;
    }
    float elemX = matCenterPoints3D.GetValue(1, 0)+cos(angle)*radius;
    float elemY = matCenterPoints3D.GetValue(1, 1)+sin(angle)*radius;
    float elemZ = matCenterPoints3D.GetValue(1, 2);

    circlePoints3D[1].SetValue(k, 0, elemX);
    circlePoints3D[1].SetValue(k, 1, elemY);
    circlePoints3D[1].SetValue(k, 2, elemZ);

    angle+=PI/16;
  }

  angle = 0;
  for (int k=0; k<numElem; k++)
  {
    if (angle>TWO_PI)
    {
      break;
    }
    float elemX = matCenterPoints3D.GetValue(2, 0);
    float elemY = matCenterPoints3D.GetValue(2, 1)+sin(angle)*radius;
    float elemZ = matCenterPoints3D.GetValue(2, 2)+cos(angle)*radius;

    circlePoints3D[2].SetValue(k, 0, elemX);
    circlePoints3D[2].SetValue(k, 1, elemY);
    circlePoints3D[2].SetValue(k, 2, elemZ);

    angle+=PI/16;
  }
}

void DrawEllipses(Matrix[] circlePoints2D)
{
  strokeWeight(3);

  int numElem = 32;
  for (int i=0; i<circlePoints2D.length; i++)
  {
    for (int k=1; k<numElem; k++)
    {
      line(circlePoints2D[i].GetValue(k-1, 0), -circlePoints2D[i].GetValue(k-1, 1), 
        circlePoints2D[i].GetValue(k, 0), -circlePoints2D[i].GetValue(k, 1));
    }
    line(circlePoints2D[i].GetValue(0, 0), -circlePoints2D[i].GetValue(0, 1), 
      circlePoints2D[i].GetValue(numElem-1, 0), -circlePoints2D[i].GetValue(numElem-1, 1));
  }
}

Matrix FindAllCenterPoints3D(Matrix cube)
{
  Matrix matCenterPoints = new Matrix(3, 4);
  float xf = (cube.GetValue(5, 0)+cube.GetValue(6, 0))/2;
  float yf = (cube.GetValue(5, 1)+cube.GetValue(6, 1))/2;
  float zf = (cube.GetValue(5, 2)+cube.GetValue(6, 2))/2;
  float xs = (cube.GetValue(7, 0)+cube.GetValue(4, 0))/2;
  float ys = (cube.GetValue(7, 1)+cube.GetValue(4, 1))/2;
  float zs = (cube.GetValue(7, 2)+cube.GetValue(4, 2))/2;

  float xcenter = (xf+xs)/2;
  float ycenter = (yf+ys)/2;
  float zcenter = (zf+zs)/2;

  matCenterPoints.SetValue(0, 0, xcenter);
  matCenterPoints.SetValue(0, 1, ycenter);
  matCenterPoints.SetValue(0, 2, zcenter);

  xf = (cube.GetValue(1, 0)+cube.GetValue(6, 0))/2;
  yf = (cube.GetValue(1, 1)+cube.GetValue(6, 1))/2;
  zf = (cube.GetValue(1, 2)+cube.GetValue(6, 2))/2;
  xs = (cube.GetValue(2, 0)+cube.GetValue(7, 0))/2;
  ys = (cube.GetValue(2, 1)+cube.GetValue(7, 1))/2;
  zs = (cube.GetValue(2, 2)+cube.GetValue(7, 2))/2;

  xcenter = (xf+xs)/2;
  ycenter = (yf+ys)/2;
  zcenter = (zf+zs)/2;

  matCenterPoints.SetValue(1, 0, xcenter);
  matCenterPoints.SetValue(1, 1, ycenter);
  matCenterPoints.SetValue(1, 2, zcenter);

  xf = (cube.GetValue(2, 0)+cube.GetValue(7, 0))/2;
  yf = (cube.GetValue(2, 1)+cube.GetValue(7, 1))/2;
  zf = (cube.GetValue(2, 2)+cube.GetValue(7, 2))/2;
  xs = (cube.GetValue(3, 0)+cube.GetValue(4, 0))/2;
  ys = (cube.GetValue(3, 1)+cube.GetValue(4, 1))/2;
  zs = (cube.GetValue(3, 2)+cube.GetValue(4, 2))/2;

  xcenter = (xf+xs)/2;
  ycenter = (yf+ys)/2;
  zcenter = (zf+zs)/2;

  matCenterPoints.SetValue(2, 0, xcenter);
  matCenterPoints.SetValue(2, 1, ycenter);
  matCenterPoints.SetValue(2, 2, zcenter);

  return matCenterPoints;
}
