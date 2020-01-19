void setup() {

  /* Inizializzazione seriale */
  Serial.begin(9600);
}

void loop() {

  /* Aspetta carattere G e operazione */
  while(Serial.available()<2);
  char g = Serial.read();
  char op = Serial.read();

  /* DEBUG */
  Serial.print(g);
  Serial.print(op);

  if(op=='0' || op=='1')
  {
    /* Aspetta 4 caratteri */
    while(Serial.available()<4);
    
    byte value0 = Serial.read();
    byte value1 = Serial.read();
    int X = (int)value0+(int)value1;
    
    value0 = Serial.read();
    value1 = Serial.read();
    int Y = (int)value0+(int)value1;

    
    if(op=='0')
      spostati(X,Y);
    else 
      disegna(X,Y);
    
  }
  else if(op=='2')
  {
    int X=0;
    int Y=0;
    spostati(X,Y);
  }

  
  /* Scrive OK sulla seriale */
  if(op=='0' || op=='1' || op=='2')
  {
    Serial.print('O');
    Serial.print('K');
  }
  
}
