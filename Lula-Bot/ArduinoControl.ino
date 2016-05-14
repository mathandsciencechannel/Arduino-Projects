int echoPin = 8;
int trigPin = 7;
int RightForward = 6;
int RightBackward = 5;
int LeftForward = 10;
int LeftBackward = 9;
int TurnTime1 = 0;
int TurnTime2 = 0;
int TurnTime3 = 0;
int autodrive = 0;
int distanceEnabled = 0;
long duration, distance, averagedistance;

int nextAction = 1;

int closedistance = 20;

char inByte = 0;

//#include <SoftwareSerial.h>// import the serial library

//SoftwareSerial HC05(2, 4); // RX, TX

void setup() {
    Serial.begin(9600);
    pinMode(trigPin, OUTPUT);
    pinMode(echoPin, INPUT);
    pinMode(RightForward, OUTPUT);
    pinMode(LeftForward, OUTPUT);
    pinMode(RightBackward, OUTPUT);
    pinMode(LeftBackward, OUTPUT);
    

    
    }
void Move(int RightF, int RightB, int LeftF, int LeftB)
{
  digitalWrite(RightForward, 0);
  digitalWrite(LeftForward, 0);
  digitalWrite(RightBackward, 0);
  digitalWrite(LeftBackward, 0);
  //if (RightF > 0 and RightB > 0)
//{
 // return;
 // }
  if (LeftF > 0 and LeftB > 0)
  {
  return;
  }

  analogWrite(LeftForward, LeftF);
  analogWrite(RightForward, RightF);
  analogWrite(RightBackward, RightB);
  
  analogWrite(LeftBackward, LeftB);
 
 
}

void MoveFB(int Speed)
{
  if (Speed > 0)
  {
    Move(abs(Speed), 0, abs(Speed), 0);
  }
  if (Speed < 0)
  {
    Move(0, abs(Speed), 0, abs(Speed));
  }
  if (Speed == 0)
  {
    Move(0,0,0,0);
  }
}

void MoveLR(int Speed)
{
  if (Speed > 0)
  {
    Move(abs(Speed), 0, 0, abs(Speed));
  }
  if (Speed < 0)
  {
    Move(0, abs(Speed), abs(Speed), 0);
  }
}

void ToggleAutoDrive(int Auto)
{
  autodrive = Auto;
  Stop();
}
void ToggleDistanceEnabled(int DistanceEnabled)
{
  distanceEnabled = DistanceEnabled;
}

void Right(int Speed)
{
  Serial.print(distance);
  Serial.println(" R");
  MoveLR(Speed);
}
void Left(int Speed)
{
  Serial.print(distance);
  Serial.println(" L");
  MoveLR(-Speed);
}
void Forward(int Speed)
{
  Serial.print(distance);
  Serial.println(" F");
  MoveFB(Speed);
}
void Backward(int Speed)
{
  Serial.print(distance);
  Serial.println(" B");
  MoveFB(-Speed);
}
void Stop()
{
  Serial.print(distance);
  Serial.println(" S");
  MoveFB(0);
  MoveLR(0);
}
String command;

void parseCommand(String com)
        {
          String part1;
          String part2;

          part1 = com.substring(0, com.indexOf(" "));
          part2 = com.substring(com.indexOf(" ") +1);

          if(part1.equalsIgnoreCase("Right"))
          {
            Right(part2.toInt());
          }
          else if(part1.equalsIgnoreCase("Left"))
          {
            Left(part2.toInt());
          }
          else if(part1.equalsIgnoreCase("Forward"))
          {
            Forward(part2.toInt());
          }
          else if(part1.equalsIgnoreCase("Backward"))
          {
            Backward(part2.toInt());
          }
          else if(part1.equalsIgnoreCase("Stop"))
          {
            Stop();
          }
          else if(part1.equalsIgnoreCase("AutoDrive"))
          {
            ToggleAutoDrive(part2.toInt());
          }
          else if(part1.equalsIgnoreCase("DistanceEnabled"))
          {
            ToggleDistanceEnabled(part2.toInt());
          }
          else
          {
             Serial.println("Invalid CMD | " + part1);
          }
          
          
        }
int getAverageDistance(int trials)
{

         digitalWrite(trigPin, LOW);
         delayMicroseconds(2);
         digitalWrite(trigPin, HIGH);
         delayMicroseconds(10);
         digitalWrite(trigPin, LOW);
         duration = pulseIn(echoPin, HIGH);
         distance = duration*0.034/2;
         delay(200);
         return distance;
         
}

         

void loop() {
  
         LoopBeggining:
         //delay(200);

          if(Serial.available())
         {
          char c = Serial.read();

          if(c == '\n')
          {
            parseCommand(command);
            command = "";
          }
          else
          {
            command += c;
            goto LoopBeggining;
          }
         }
         

         if (distanceEnabled == 1)
         {
            
            distance = getAverageDistance(1);
            if (autodrive == 1)
            {
            if (distance <= closedistance )//if we are within 20 centimeters
            {
              switch(nextAction)
              {
                case 1: //1 = right
                 
                   Right(255);
                   delay(200);
                   //Stop();
                   nextAction = 2;
                   goto LoopBeggining;
                 break;
                 
                 case 2: // 2 = left
                 
                   Left(255);
                   delay(400);
                   //Stop();
                   nextAction = 3;
                   goto LoopBeggining;
                 break;
                 
                 case 3: // 3 = back
                 
                    Right(255);
                   delay(200);
                  // Stop();
                  nextAction = 4;
                   goto LoopBeggining;
                break;
                 case 4:                    
                   Backward(255);
                   delay(500);
                   //Stop();
                   nextAction = 1;
                   goto LoopBeggining;
                 break;
              }
            }
            else
            {
              Forward(255);
            }
            
            

         }
         else
         {
         Serial.print(distance);
         Serial.println(" M");
         }

         }  
         else
         {
         Serial.print("Disabled");
         Serial.println(" M");
          }
         }
         



         
         
         
             


                


