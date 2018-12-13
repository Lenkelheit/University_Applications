// FUNCTIONS
void DrawCoordinatePlane()
{
  translate(width/2, height/2);
  strokeWeight(10);
  point(0, 0);
  strokeWeight(2);

  // вісь ox
  line(-width*3/8, 0, width*3/8, 0);
  line(width*3/8, 0, width*3/8-5, 3);
  line(width*3/8, 0, width*3/8-5, -3);

  // вісь oy
  line(0, height*3/8, 0, -height*3/8);
  line(0, -height*3/8, -3, -height*3/8+5);
  line(0, -height*3/8, 3, -height*3/8+5);

  textSize(18);
  fill(100);
  text("x", width*3/8+3, 7);
  text("y", 7, -height*3/8);
}
