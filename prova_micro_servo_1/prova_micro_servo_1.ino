#include <Servo.h>
#include <Stepper.h>

#define LINE_BUFFER_LENGTH 512

const int penZUp = -30;  
const int penZDown = 40;

const int penServoPin = 6;

const int stepsPerRevolution = 60; 

Servo penServo;  

Stepper myStepperY(stepsPerRevolution, 5,3,4,2);            
Stepper myStepperX(stepsPerRevolution, 11,9,10,8);  

struct point { 
  float x; 
  float y; 
  float z; 
};

struct point actuatorPos;

float StepInc = 1;
int StepDelay = 0;
int LineDelay = 50;
int penDelay = 50;


float Xmin = 0;
float Xmax = 100;
float Ymin = 0;
float Ymax = 100;
float Zmin = 0;
float Zmax = 1;

float Xpos = Xmin;
float Ypos = Ymin;
float Zpos = Zmax; 

boolean verbose = false;
void setup() {

  Serial.begin( 9600 );
  
  penServo.attach(penServoPin);   //Collega la variabile penServoPin a un pin
  penServo.write(penZUp);
  delay(200);

}

void loop() {

penDown();
delay(5000);
penUp();
delay(2000);
  
}


void penUp() { 
  penServo.write(penZUp); 
  delay(LineDelay); 
  Zpos=Zmax; 
  if (verbose) { 
    Serial.println("Pen up!"); 
  } 
}
void penDown() { 
  penServo.write(penZDown); 
  delay(LineDelay); 
  Zpos=Zmin; 
  if (verbose) { 
    Serial.println("Pen down."); 
  } 
}
