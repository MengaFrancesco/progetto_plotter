#include <Servo.h>
#include <Stepper.h>

const int penZUp = 40;
const int penZDown = -40;

const int penServoPin = 6;

const int stepsPerRevolution = 60; 

Servo penServo;  

Stepper myStepperY(stepsPerRevolution, 5,3,4,2);            
Stepper myStepperX(stepsPerRevolution, 11,9,10,8);  

 float StepsPerMillimeterX = 300.0;
float StepsPerMillimeterY = 300.0;

float Xmin = 0;
float Xmax = 300;
float Ymin = 0;
float Ymax = 300;
float Zmin = 0;
float Zmax = 1;

float Xpos = Xmin;
float Ypos = Ymin;
float Zpos = Zmax; 
void setup()
{
  Serial.begin( 9600 );
  penServo.attach(penServoPin);
  penServo.write(penZUp);
  delay(200);

  myStepperX.setSpeed(200);
}
 
void loop()
{

  / * Aspetta carattere G e operazione * /
  while (Serial. available () < 2 );
  char g = Serial. read ();
  char op = Serial. read ();

  / * DEBUG * /
  Serial.println (op);
  Serial.println (g);

  if (op == ' 0 ' || op == ' 1 ' )
  {
    / * Aspetta 4 caratteri * /
    while (Serial. available () < 4 );
    
    byte value0 = Serial. read ();
    byte value1 = Serial. read ();
    int X = ( int ) value0 + ( int ) value1;
    
    valore0 = Serial. read ();
    value1 = Serial. read ();
    int Y = ( int ) value0 + ( int ) value1;

    
    if (op == ' 0 ' )
      spostati (X, Y);
    else 
      disegna(X, Y);
    
  }
  else  if (op == ' 2 ' )
  {
    int X = 0 ;
    int Y = 0 ;
    spostati(X, Y);
  }

  
  / * Scrive OK sulla seriale * /
  if (op == ' 0 ' || op == ' 1 ' || op == ' 2 ' )
  {
    Serial. print ( ' O ' );
    Serial. print ( ' K ' );
  }

  
 }
}

//SPOSTA LA PENNA SU UN PUNTO DI COORDINATE (x1,y1) SENZA DISEGNARE
void spostati(int x1,int y1)
{
  penUp();
  if (x1 >= Xmax) { 
    x1 = Xmax; 
  }
  if (x1 <= Xmin) { 
    x1 = Xmin; 
  }
  if (y1 >= Ymax) { 
    y1 = Ymax; 
  }
  if (y1 <= Ymin) { 
    y1 = Ymin; 
  }
  x1 = (int)(x1*StepsPerMillimeterX);
  y1 = (int)(y1*StepsPerMillimeterY);
  
    float x0 = Xpos;
  float y0 = Ypos;

   long dx = abs(x1-x0);
  long dy = abs(y1-y0);
  int sx = x0<x1 ? StepInc : -StepInc;
  int sy = y0<y1 ? StepInc : -StepInc;

long i;
  long over = 0;

  if (dx > dy) {
    for (i=0; i<dx; ++i) {
      myStepperX.step(sx);
      over+=dy;
      if (over>=dx) {
        over-=dx;
        myStepperY.step(sy);
      }
      delay(StepDelay);
    }
  }
  else {
    for (i=0; i<dy; ++i) {
      myStepperY.step(sy);
      over+=dx;
      if (over>=dy) {
        over-=dy;
        myStepperX.step(sx);
      }
      delay(StepDelay);
    }    
  }
  
   Xpos = x1;
  Ypos = y1;
}
//ABBASSA LA PENNA E DISEGNA FNO AD UN PUNTO DI COORDINATE (x1,y1) 
void disegna(int x1,int y1)
{
  penDown();
   if (x1 >= Xmax) { 
    x1 = Xmax; 
  }
  if (x1 <= Xmin) { 
    x1 = Xmin; 
  }
  if (y1 >= Ymax) { 
    y1 = Ymax; 
  }
  if (y1 <= Ymin) { 
    y1 = Ymin; 
  }
  x1 = (int)(x1*StepsPerMillimeterX);
  y1 = (int)(y1*StepsPerMillimeterY);
  
    float x0 = Xpos;
  float y0 = Ypos;

   long dx = abs(x1-x0);
  long dy = abs(y1-y0);
  int sx = x0<x1 ? StepInc : -StepInc;
  int sy = y0<y1 ? StepInc : -StepInc;

long i;
  long over = 0;

  if (dx > dy) {
    for (i=0; i<dx; ++i) {
      myStepperX.step(sx);
      over+=dy;
      if (over>=dx) {
        over-=dx;
        myStepperY.step(sy);
      }
      delay(StepDelay);
    }
  }
  else {
    for (i=0; i<dy; ++i) {
      myStepperY.step(sy);
      over+=dx;
      if (over>=dy) {
        over-=dy;
        myStepperX.step(sx);
      }
      delay(StepDelay);
    }    
  }
  
   Xpos = x1;
  Ypos = y1;
}
void penUp() { 
  penServo.write(penZUp); 
  delay(LineDelay); 
  Zpos=Zmax; 
   
}
void penDown() { 
  penServo.write(penZDown); 
  delay(LineDelay); 
  Zpos=Zmin; 
  
}

}  
}
