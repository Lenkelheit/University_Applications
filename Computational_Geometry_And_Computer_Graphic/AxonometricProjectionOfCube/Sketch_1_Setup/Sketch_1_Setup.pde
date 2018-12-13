/*
Побудувати аксонометричну проекцію куба
з вписаними в його грані колами
при співвідношенні масштабів
kx : ky : kz = 6 : 5 : 4.
*/

void setup()
{
  size(480, 480);
  background(255);
  stroke(150, 70);
  int kx = 6;
  int ky = 5;
  int kz = 4;

  float c = GetC(kx, ky, kz);

  float mx = kx*c;
  float my = ky*c;
  float mz = kz*c;

  float fix = acos(my);
  float fiy = -acos(sqrt((1-pow(mz, 2))/pow(my, 2)));

  int n = 4;
  Matrix cubeOn3D = CreateCube(n);
  for (int i=0; i<cubeOn3D.numberRows; i++)
  {
    for (int j=0; j<cubeOn3D.numberColumns-1; j++)
    {
      cubeOn3D.matrix[i][j]*=120;
    }
  }

  float radius = dist(cubeOn3D.GetValue(0, 0), cubeOn3D.GetValue(0, 1), 
    cubeOn3D.GetValue(0, 2), cubeOn3D.GetValue(1, 0), 
    cubeOn3D.GetValue(1, 1), cubeOn3D.GetValue(1, 2))/2;

  Matrix cubeOn2D = cubeOn3D.MultiplyTo(GetMatrixT(fix, fiy));

  Matrix matCenterPoints3D = FindAllCenterPoints3D(cubeOn3D);
  Matrix matCenterPoints2D = matCenterPoints3D.MultiplyTo(GetMatrixT(fix, fiy));

  Matrix[] circlePoints3D = new Matrix[3];
  FillMatrixCirclePoints(circlePoints3D, matCenterPoints3D, radius);
  Matrix[] circlePoints2D = new Matrix[3];
  for (int i=0; i<circlePoints2D.length; ++i)
  {
    circlePoints2D[i]=circlePoints3D[i].MultiplyTo(GetMatrixT(fix, fiy));
  }
  DrawCoordinatePlane();
  ConnectCubePointsAndDraw(cubeOn2D);
  DrawEllipses(circlePoints2D);
  DrawCentersOfEllipses(matCenterPoints2D);
}
