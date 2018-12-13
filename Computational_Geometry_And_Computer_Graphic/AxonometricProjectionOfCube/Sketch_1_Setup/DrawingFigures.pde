// FUNCTIONS
void DrawCubePoints(Matrix cube)
{
  strokeWeight(6);
  for (int i=0; i<cube.numberRows; i++)
  {
    point(cube.GetValue(i, 0), -cube.GetValue(i, 1));
  }
}

void ConnectCubePointsAndDraw(Matrix cube)
{
  strokeWeight(6);
  fill(255);
  // малюється нижня грань
  quad(cube.GetValue(0, 0), -cube.GetValue(0, 1), 
    cube.GetValue(1, 0), -cube.GetValue(1, 1), 
    cube.GetValue(2, 0), -cube.GetValue(2, 1), 
    cube.GetValue(3, 0), -cube.GetValue(3, 1));

  // малюється задня грань
  line(cube.GetValue(0, 0), -cube.GetValue(0, 1), 
    cube.GetValue(5, 0), -cube.GetValue(5, 1));
  line(cube.GetValue(3, 0), -cube.GetValue(3, 1), 
    cube.GetValue(4, 0), -cube.GetValue(4, 1));

  // малюється верхня грань
  quad(cube.GetValue(4, 0), -cube.GetValue(4, 1), 
    cube.GetValue(5, 0), -cube.GetValue(5, 1), 
    cube.GetValue(6, 0), -cube.GetValue(6, 1), 
    cube.GetValue(7, 0), -cube.GetValue(7, 1));

  // малюється права бічна грань
  quad(cube.GetValue(2, 0), -cube.GetValue(2, 1), 
    cube.GetValue(3, 0), -cube.GetValue(3, 1), 
    cube.GetValue(4, 0), -cube.GetValue(4, 1), 
    cube.GetValue(7, 0), -cube.GetValue(7, 1));

  // малюється передня грань
  quad(cube.GetValue(1, 0), -cube.GetValue(1, 1), 
    cube.GetValue(6, 0), -cube.GetValue(6, 1), 
    cube.GetValue(7, 0), -cube.GetValue(7, 1), 
    cube.GetValue(2, 0), -cube.GetValue(2, 1));
}
