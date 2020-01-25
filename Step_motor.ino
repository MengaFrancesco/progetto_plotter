#include <Servo.h>
#include <Stepper.h>

/* Inizializzazione posizioni Servo Motor */
const int penZUp = 40;
const int penZDown = -40;

/* Inizializzazione del Servo Motor */
const int penServoPin = 6;
Servo penServo;  
const int stepsPerRevolution = 60; 

/* Inizializzazione StepMotor */
Stepper myStepperY(stepsPerRevolution, 5,3,4,2);            
Stepper myStepperX(stepsPerRevolution, 11,9,10,8);  

float StepsPerMillimeterX = 300.0;
float StepsPerMillimeterY = 300.0;

/* Coordinate minime e massime del foglio di disegno */
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
  Serial.begin( 9600 );          /* Inizializzazione seriale */
  
  /* Imposta la penna in posizione alzata */
  penServo.attach(penServoPin);
  penServo.write(penZUp);
  delay(200);

  /* Imposta le rotazioni per minuto */
  myStepperX.setSpeed(200);
  myStepperY.setSpeed(200);
}
 
void loop()
{

  /* Aspetta carattere G e operazione */
  while (Serial. available () < 2 );
  char g = Serial. read ();
  char op = Serial. read ();

  if (op == ' 0 ' || op == ' 1 ' ) /* Se G0 o G1 */
  {
    /* Aspetta i 4 caratteri successivi */
    while (Serial. available () < 4 );
    
    /* Somma i 2 byte letti */
    byte value0 = Serial. read ();
    byte value1 = Serial. read ();
    int X = ( int ) value0 + ( int ) value1;
    
   /* Somma i 2 byte letti */
    byte valore2 = Serial.read();
    byte value3 = Serial.read ();
    int Y = ( int ) value0 + ( int ) value1;
    
    if (op == ' 0 ' ) /* G0 */
      spostati (X, Y, false);
    else /* G1 */
      spostati(X, Y, true);
  }
  else  if (op == ' 2 ' ) /* G2 */
  {
    /* Spostamento in alto a sinistra, alle coordinate 0,0 */
    int X = 0 ;
    int Y = 0 ;
    spostati(X,Y, false);
  }

  
  /* Scrive OK sulla seriale per ricevere il prossimo comando */
  if (op == ' 0 ' || op == ' 1 ' || op == ' 2 ' )
  {
    Serial. print ('O');
    Serial. print ('K');
  }  
 }
}

/* SPOSTA LA PENNA SU UN PUNTO DI COORDINATE (x1,y1) E CONTROLLA SE DEVE DISEGNARE */
void spostati(int x1,int y1, bool disegna)
{
  if(disegna) 
   penDown(); /* Deve disegnare */
  else 
   penUp(); /* Deve solo spostarsi */
  
  /* Controlla che le coordinate non siano oltre il foglio */
  if (x1 >= Xmax) x1 = Xmax; 
  if (x1 <= Xmin) x1 = Xmin; 
  if (y1 >= Ymax) y1 = Ymax; 
  if (y1 <= Ymin) y1 = Ymin; 
  
  /* Imposta le coordinate finali */
  x1 = (int)(x1*StepsPerMillimeterX);
  y1 = (int)(y1*StepsPerMillimeterY);
  
  /* Imposta coordinate iniziali */
  float x0 = Xpos;
  float y0 = Ypos;

  long dx = abs(x1-x0); /* Calcola distanza X */
  long dy = abs(y1-y0); /* Calcola distanza Y */
  int sx = x0<x1 ? StepInc : -StepInc; /* Imposta rotazione oraria o antioraria */
  int sy = y0<y1 ? StepInc : -StepInc; /* Imposta rotazione oraria o antioraria */

  long i;
  long over = 0;

  if (dx > dy) {  /* Se distanza tra le X maggiore di quella tra le Y */
    for (i=0; i < dx; ++i) { 
      myStepperX.step(sx);
      over+=dy;
      if (over>=dx) {
        over-=dx;
        myStepperY.step(sy);
      }
      delay(StepDelay); /* Aspetta che la linea sia terminata */
    }
  }
  else { /* Se distanza tra le Y maggiore di quella tra le X */
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

/* Metodo che alza la penna */
void penUp() { 
  penServo.write(penZUp); 
  delay(LineDelay); 
  Zpos=Zmax; 
}

/* Metodo che abbassa la penna */
void penDown() { 
  penServo.write(penZDown); 
  delay(LineDelay); 
  Zpos=Zmin; 
}
}  
}
