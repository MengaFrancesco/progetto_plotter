/*
  Stepper Motor Demonstration 1
  Stepper-Demo1.ino
  Demonstrates 28BYJ-48 Unipolar Stepper with ULN2003 Driver
  Uses Arduino Stepper Library
 
  DroneBot Workshop 2018
  https://dronebotworkshop.com
*/
 
//Include the Arduino Stepper Library
#include <Stepper.h>
#include <Servo.h>

const int penZUp = 40;  
const int penZDown = 80;

const int penServoPin = 6;

const int stepsPerRevolution = 60; 
// Define Variables
 int x;
 int y;
int z;
float StepsPerMillimeterX = 500.0;
float StepsPerMillimeterY = 500.0;

 float Xmin = 0;
float Xmax = 500;
float Ymin = 0;
float Ymax = 500;
float Zmin = 0;
float Zmax = 1;

 String comando;
 
Servo penServo;  

Stepper myStepperY(stepsPerRevolution, 5,3,4,2);            
Stepper myStepperX(stepsPerRevolution, 11,9,10,8);  
 
void setup()
{
 Serial.begin( 9600 );
  
  penServo.attach(penServoPin);   //Collega la variabile penServoPin a un pin
  penServo.write(penZUp);
  delay(200);

  myStepperX.setSpeed(200);
  myStepperY.setSpeed(200);  
}
 
void loop()
{
  while ( Serial.available()<2 ); 
char g = Serial.read();
char com = Serial.read();


if(com=='2'){
   Serial.println("Sto eseguendo...");
    ripristinaPosizione();
    Serial.println("ok");
  
}else if(com=='0'){
   while ( Serial.available()<4 );
    
    int x= Serial.read();
    int y= Serial.read();
    Serial.println("Sto eseguendo...");
    spostati(x,y);
    Serial.println("ok");
}else if(com=='1'){
 while ( Serial.available()<4 ); 
 
    int x= Serial.read();
    int y= Serial.read();
    Serial.println("Sto eseguendo...");
    disegna(x,y);
    Serial.println("ok");

  
 }
}
  



//RIPRISTINA I MOTORI ALLA POSIZIONE INIZIALE
void ripristinaPosizione(){

  newPos.x = 0.0;
  newPos.y = 0.0;

}
//SPOSTA LA PENNA SU UN PUNTO DI COORDINATE (x2,y2) SENZA DISEGNARE
void spostati(int x2,int y2)    //G1
{

  penUp();
 x = x2;
  y = y2;
  
  // Rotate CCW 1/2 turn quickly
  StepsRequired  =  - STEPS_PER_OUT_REV / 2;   
  steppermotor.setSpeed(1000);  
  steppermotor.step(StepsRequired);
  delay(2000);
}
//ABBASSA LA PENNA E DISEGNA FNO AD UN PUNTO DI COORDINATE (x2,y2) 
void disegna(int x2,int y2)
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
  delay(LineDelay);
  
  Xpos = x1;
  Ypos = y1;
  penUp();
}
void penUp(){ 
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
