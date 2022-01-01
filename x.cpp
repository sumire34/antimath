#include <iostream>
#include <iomanip>
using namespace std;
 


int main(){
float janex1=0, glessx2=0, janex3=0, glessa=0, janeb=0, glessc=0, janei=1, userlimit, blankcontainer;

    cout<<"Welcome to Gauss Jacobi\n";
    int gjacobi[3][4];

            for (int x=0; x<3; x++){ 
                for (int y=0; y<4; y++){
                    cin >> gjacobi[x][y];
                    }
                }
                    cout<<"How many iterations? ->";
                        cin>>userlimit;
                        cout<<"\n\n\n\n Equations:\n "<<gjacobi[0][0]<<"x1 + "<<gjacobi[0][1]<<"y1 + "<<gjacobi[0][2]<<"z1 = "<<gjacobi[0][3]<<"\n";
                        cout<<" "<<gjacobi[1][0]<<"x2 + "<<gjacobi[1][1]<<"y2 + "<<gjacobi[1][2]<<"z2 = "<<gjacobi[1][3]<<"\n";
                        cout<<" "<<gjacobi[2][0]<<"x3 + "<<gjacobi[2][1]<<"y3 + "<<gjacobi[2][2]<<"z3 = "<<gjacobi[2][3]<<"\n\n";
                        cout<<"\n .------------------------------------------------.";
                        cout<<"\n |  Iteration  |     "<<"x1         "<<"x2        "<<"x3      |";
                        cout<<"\n |------------------------------------------------|";
                        cout<<"\n |      "<<janei<<fixed <<setprecision(4)<<"      |   "<<janex1<<"     "<<glessx2<<"    "<<janex3<<"    |";
                            for(int i=2; i<userlimit+1; i++){
                                janex1=(gjacobi[0][3]+(gjacobi[0][1]*janeb*-1)+(gjacobi[0][2]*glessc*-1))/gjacobi[0][0];    
                                glessx2=(gjacobi[1][3]+(gjacobi[1][0]*glessa*-1)+(gjacobi[1][2]*glessc*-1))/gjacobi[1][1];
                                janex3=(gjacobi[2][3]+(gjacobi[2][0]*glessa*-1)+(gjacobi[2][1]*janeb*-1))/gjacobi[2][2];
                                glessa=janex1, janeb=glessx2, glessc=janex3;
                                cout<<"\n |      "<<i<<"      |   "<<janex1<<"    "<<glessx2<<"    "<<janex3<<"    |";
                            }  
                        cout<<"\n '------------------------------------------------'\n\n"; 
                        cout<<fixed <<setprecision(0);
                        cout<<"\n              Sequences converges at:            \n";
                        cout<<"          x1 = "<<janex1<<"  |  x2 = "<<glessx2<<"  |  x3 = "<<janex3<<"          ";
                        cout<<"\n\n\nenter to continue\n";
                        cin.ignore();
                        cin.get();

return 0;
}