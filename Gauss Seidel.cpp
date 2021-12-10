#include <iostream>
#include <iomanip>
using namespace std;
 
void Seidel(){
cout<<"";
}
void bracket1(){
cout<<"";
}   
void bracket2(){
cout<<"";
} 
void bracket3(){
cout<<"";
} 
void clr(){
cout<<"";
} 
void clrs(){
cout<<"";
} 
 


int main(){
float x1=0, x2=0, x3=0, a=0, b=0, c=0, i=1, userlimit, blankcontainer;

Seidel();
clrs();
    cout<<"Welcome to Gauss Seidel Method\n";
    int eq[3][4];
        cout<<"Please enter the coefficients, values are separated with a space.\n\n";
        cout<<"Example                   Your Input\n";
        cout<<"1x + 2y + 3z = 4          1 2 3 4  ->hit enter\n";
        cout<<"5x + 6y + 7z = 8    >>    5 6 7 8  ->hit enter     or      1 2 3 4 5 6 7 8 9 1 2 3    ->hit enter\n";
        cout<<"9x + 1y + 2z = 3          9 1 2 3  ->hit enter"<<"\n\nYour input:\n";
            for (int x=0; x<3; x++){ 
                for (int y=0; y<4; y++){
                    cin >> eq[x][y];
                    }
                }
                    cout<<"How many iterations do you want?  ->";
                        cin>>userlimit;
                    clr();
                    Seidel();
                        cout<<"\n\n\n\n Equations:\n "<<eq[0][0]<<"x1 + "<<eq[0][1]<<"y1 + "<<eq[0][2]<<"z1 = "<<eq[0][3]<<"\n";
                        cout<<" "<<eq[1][0]<<"x2 + "<<eq[1][1]<<"y2 + "<<eq[1][2]<<"z2 = "<<eq[1][3]<<"\n";
                        cout<<" "<<eq[2][0]<<"x3 + "<<eq[2][1]<<"y3 + "<<eq[2][2]<<"z3 = "<<eq[2][3]<<"\n\n";
                    bracket1();
                        cout<<"\n |  Iteration  |     "<<"x1         "<<"x2        "<<"x3      |\n";
                    bracket2();
                        cout<<" |      "<<i<<fixed <<setprecision(4)<<"      |   "<<x1<<"     "<<x2<<"    "<<x3<<"    |\n";
                            for(int i=2; i<userlimit+1; i++){
                                x1=(eq[0][3]+(eq[0][1]*b*-1)+(eq[0][2]*c*-1))/eq[0][0];
                                    a=x1;
                                x2=(eq[1][3]+(eq[1][0]*a*-1)+(eq[1][2]*c*-1))/eq[1][1];
                                    b=x2;
                                x3=(eq[2][3]+(eq[2][0]*a*-1)+(eq[2][1]*b*-1))/eq[2][2];
                                    c=x3;
                                cout<<" |      "<<i<<"      |   "<<x1<<"    "<<x2<<"    "<<x3<<"    |\n";
                            }   
                    bracket3();
                        cout<<fixed <<setprecision(0);
                    bracket1();
                        cout<<"\n |             Sequences converges at:            |\n";
                        cout<<" |         x1 = "<<x1<<"  |  x2 = "<<x2<<"  |  x3 = "<<x3<<"          |                      Press enter to continue...\n";
                    bracket3();
                        cin.ignore();
                        cin.get();

return 0;
}