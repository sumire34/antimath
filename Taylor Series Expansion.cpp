#include <iostream>
#include <iomanip>
using namespace std;

void Taylor(){ 
cout<<"                   _______               __                  _______              __\n";
cout<<"                  |_     _|.---.-.--.--.|  |.-----.----.    |     __|.-----.----.|__|.-----.-----.\n";
cout<<"                    |   |  |  _  |  |  ||  ||  _  |   _|    |__     ||  -__|   _||  ||  -__|__ --|\n";
cout<<"                    |___|  |___._|___  ||__||_____|__|      |_______||_____|__|  |__||_____|_____|\n";
cout<<"                                 |_____|\n";                                                                             
cout<<"                               _______                                 __\n";             
cout<<"                              |    ___|.--.--.-----.---.-.-----.-----.|__|.-----.-----.\n";
cout<<"                              |    ___||_   _|  _  |  _  |     |__ --||  ||  _  |     |\n";
cout<<"                              |_______||__.__|   __|___._|__|__|_____||__||_____|__|__|\n";
cout<<"                                             |__|\n";                                      
}
void tsbracket1(){
cout<<" .---------------------------------------------------------.";
}   
void tsbracket2(){
cout<<" |---------------------------------------------------------|\n";
} 
void tsbracket3(){
cout<<" '---------------------------------------------------------'\n";
} 
void clr(){
cout<<"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
} 
void clrs(){
cout<<"\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n";
} 
void clrxs(){
cout<<"\n\n\n\n\n";
} 
 

int main(){
    float tsx, term, cf1, cf2, pw1, pw2, spw1=1, spw2=1, fspw1=1, fspw2=1;
    cout<<"                                                      f''(a)         + f'''(a)\n";
                    cout<<"                           P(x) = f(a) + f'(a)(x-a) + ------ (x-a)^2 + ------- (x-a)^3 + ...\n";
                    cout<<"                                                        2!               3!\n\n\n\n\n";
                    cout<<"Welcome to Taylor Series Expansion\n";
                    int ts[5], tsclone[5];
                    float dstorage[9999];
                    cout<<"Please enter the coefficients, values are separated with a space.\n\n";
                    cout<<"Given equations:             Ways to input\n";
                    cout<<"                             2   -> Hit enter\n";
                    cout<<"                             3   -> Hit enter\n";
                    cout<<"2x^3 + 4x^5 + 6      >>      4   -> Hit enter         or       2 3 4 5 6  -> Hit enter\n";
                    cout<<"                             5   -> Hit enter\n";
                    cout<<"                             6   -> Hit enter\n\n\n\n\n";
                        for(int i=0; i<5; i++){ 
                            cin>>ts[i];
                         }
                    tsclone[0]=ts[0], tsclone[1]=ts[1], tsclone[2]=ts[2], tsclone[3]=ts[3], tsclone[4]=ts[4];
                    cout<<"Near at x = ";
                    cin>>tsx;
                    cout<<"How many term do you want?";
                    cin>>term;
                    clr();
                    Taylor();
                    cout<<"\n\n\n\n     Equations:\n     "<<ts[0]<<"x^"<<ts[1]<<" + "<<ts[2]<<"x^"<<ts[3]<<" + "<<ts[4]<<"\n\n\n\n     Solutions:\n";
                    cout<<"     Finding the derivatives:                Plugging in the value of x:\n\n";
                        for(int i=0; i<ts[1]; i++){
                           fspw1=fspw1*tsx; 
                       }
                            for(int i=0; i<ts[3]; i++){
                               fspw2=fspw2*tsx; 
                            }
                    cout<<"     f"<<"0"<<"(x)"<<" = "<<ts[0]<<"x^"<<ts[1]<<" + "<<ts[2]<<"x^"<<ts[3]<<" + "<<ts[4]<<"                 f"<<"0"<<"("<<tsx<<")"<<" = "<<ts[0]<<"x^"<<ts[1]<<" + "<<ts[2]<<"x^"<<ts[3]<<" + "<<ts[4]<<"\n";
                    cout<<"                                                     = "<<ts[0]<<"("<<tsx<<")^"<<ts[1]<<" + "<<ts[2]<<"("<<tsx<<")^"<<ts[3]<<" + "<<ts[4]<<"\n";
                    cout<<"                                                     = "<<ts[0]*fspw1+ts[2]*fspw2+ts[4]<<"\n\n";
                    fspw1=1, fspw2=1; 
                        for(int i=1; i<term+1; i++){
                            cf1=ts[1]*ts[0];
                            pw1=ts[1]-1;
                            pw2=ts[3]-1;
                            cf2=ts[3]*ts[2];
                            cout<<"     f"<<i<<"(x)"<<" = "<<ts[0]<<"x^"<<ts[1]<<" + "<<ts[2]<<"x^"<<ts[3]<<"                     f"<<i<<"("<<tsx<<")"<<" = "<<cf1<<"x^"<<pw1<<" + "<<ts[3]*ts[2]<<"x^"<<pw2<<"\n";
                            cout<<"           = "<<cf1<<"x^"<<pw1<<" + "<<ts[3]*ts[2]<<"x^"<<pw2<<"                           = "<<cf1<<"("<<tsx<<")^"<<pw1<<" + "<<ts[3]*ts[2]<<"("<<tsx<<")^"<<pw2<<"\n";
                                for(int i=0; i<pw1; i++){
                                    spw1=spw1*tsx; 
                                }
                                    for(int i=0; i<pw2; i++){
                                        spw2=spw2*tsx; 
                                    }
                            cout<<"                                                     = "<<cf1*spw1+cf2*spw2<<"\n\n";
                            dstorage[i]=cf1*spw1+cf2*spw2;
                            ts[0]=cf1, ts[1]=pw1, ts[2]=cf2, ts[3]=pw2, spw1=1, spw2=1; 
                        }
                        for(int i=0; i<tsclone[1]; i++){
                           fspw1=fspw1*tsx; 
                        }
                            for(int i=0; i<tsclone[3]; i++){
                               fspw2=fspw2*tsx; 
                            }
                    cout<<" .------------------------------------------------------------------------------------------.\n";
                    cout<<" |   The taylor series for this equation will be:"<<"                                           |\n";
                    cout<<" |                                                                                          |\n";
                    cout<<" |                                            f''(a)         + f'''(a)                      |\n";
                    cout<<" |                 P(x) = f(a) + f'(a)(x-a) + ------ (x-a)^2 + ------- (x-a)^3 + ...        |\n";
                    cout<<" |                                               2!               3!                        |\n";
                    cout<<" |                                                                                          |\n";
                    cout<<" |                                                                                          |\n";
                    cout<<" |    "<<tsclone[0]<<"x^"<<tsclone[1]<<" + "<<tsclone[2]<<"x^"<<tsclone[3]<<" + "<<tsclone[4]<<" = f("<<tsx<<") + f'("<<tsx<<")"<<"(x-"<<tsx<<") + f''("<<tsx<<")/2!(x-"<<tsx<<")^2 + f'''("<<tsx<<")/3!(x-"<<tsx<<")^3 + ...    |\n";
                    cout<<" |                      = "<<tsclone[0]*fspw1+tsclone[2]*fspw2+tsclone[4]<<" + "<<dstorage[1]<<"(x-"<<tsx<<") + "<<dstorage[2]/2<<"(x-"<<tsx<<")^2 + "<<dstorage[3]/6<<"(x-"<<tsx<<")^3 + ...                       |           "<<" Press enter to continue...\n";  
                    cout<<" |                      = expand Zzz                                                        |\n";
                    cout<<" '------------------------------------------------------------------------------------------'\n";
                    cin.ignore();
                    cin.get();        
    return 0;
    }