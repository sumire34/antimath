#include <iostream>
#include <iomanip>
using namespace std;

void Secant(){
cout<<" _______                          __        _______         __   __             __ \n";
cout<<"|     __|.-----.----.---.-.-----.|  |_     |   |   |.-----.|  |_|  |--.-----.--|  |\n";
cout<<"|__     ||  -__|  __|  _  |     ||   _|    |       ||  -__||   _|     |  _  |  _  |\n";
cout<<"|_______||_____|____|___._|__|__||____|    |__|_|__||_____||____|__|__|_____|_____|\n";
}
void smbracket1(){
cout<<" .---------------------------------------------------------.";
}   
void smbracket2(){
cout<<" |---------------------------------------------------------|\n";
} 
void smbracket3(){
cout<<" '---------------------------------------------------------'\n";
} 
void clr(){
cout<<"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
} 
void clrs(){
cout<<"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
} 

int main(){
    float sma, smb, fa , fb, base1=1, base2=1, base11=1, base22=1, smx;
        cout<<"Welcome to Secant Method\n";
    int sm[4];
        cout<<"Please enter the coefficients, values are separated with a space.\n\n";
        cout<<"Example                  Your input\n";
        cout<<"2x^3 + 4x^5 + 6    >>    2 3 4 5 6\n"<<"\n\nYour input: ";
            for(int i=0; i<5; i++){ 
                cin>>sm[i];
            }
        cout<<"When a = ";
        cin>>sma;
        cout<<"and  b = ";
        cin>>smb;  
            for(int i=0; i<sm[1]; i++){
                base1=base1*sma; 
            }
                for(int i=0; i<sm[3]; i++){
                    base2=base2*sma; 
                }
            fa=(sm[0]*base1+sm[2]*base2)+sm[4];
                    for(int i=0; i<sm[1]; i++){
                        base11=base11*smb; 
                    }
                        for(int i=0; i<sm[3]; i++){
                            base22=base22*smb; 
                        }
            fb=(sm[0]*base11+sm[2]*base22)+sm[4];
            smx=sma-((fa*(smb-sma))/(fb-fa));
        int sml;
            cout<<"How many iterations do you want?  ->";
                cin>>sml;
            clr();
            Secant();
            cout<<"\n\n\n\n Equations:\n "<<sm[0]<<"x^"<<sm[1]<<" + "<<sm[2]<<"x^"<<sm[3]<<" + "<<sm[4]<<"\n\n\n";
            smbracket1();
            cout<<"\n |  Iteration  |    "<<"a        "<<"b      "<<"f(a)     "<<"f(b)      "<<"x"<<"   |\n";
            smbracket2();
            cout<<fixed <<setprecision(4);
            cout<<" |      1      | "<<sma<<"   "<<smb<<"   "<<fa<<"   "<<fb<<"   "<<fixed <<setprecision(2)<<smx<<"  |\n";
                for (int x=2; x<sml+2; x++){
                base1=1,base2=1, base11=1, base22=1,  sma=smb, smb=smx;
                    for(int i=0; i<sm[1]; i++){
                        base1=base1*sma; 
                    }
                        for(int i=0; i<sm[3]; i++){
                            base2=base2*sma; 
                        }
            fa=(sm[0]*base1+sm[2]*base2)+sm[4];
                            for(int i=0; i<sm[1]; i++){
                                base11=base11*smb; 
                            }
                                for(int i=0; i<sm[3]; i++){
                                    base22=base22*smb; 
                                }
            fb=(sm[0]*base11+sm[2]*base22)+sm[4];
            smx=sma-((fa*(smb-sma))/(fb-fa));
            cout<<" |      "<<x<<"      | "<<fixed <<setprecision(4)<<sma<<"   "<<smb<<"   "<<fa<<"   "<<fb<<"   "<<fixed <<setprecision(2)<<smx<<"  |\n";
            
        }
            smbracket3();
            cout<<"\n\n";
            smbracket1();
            cout<<"\n |           After "<<sml<<" iterations, the root is "<<smx<<".         |                    Press enter to continue...\n";
            smbracket3();
            cin.ignore();
            cin.get();
    return 0;
    }