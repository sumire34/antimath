#include <iostream>
#include <iomanip>
using namespace std;

void Home(){ 
cout<<"\n\n\n\n           [1] Start      [2] Help      [3]  Exit\n"; 
}

void Menu(){ 
cout<<"   [1] Taylor Serries Expansion     [2] Matrix Operations     [3]  Gauss Seidel    [4] Back\n"; 
}

int main(){
int x;
do{
Home();
    cout<<"\n\nPlease enter 1 or 2, 3 to execute the program: ";
    cin>>x;
switch (x){
    case 1:
    int submenu;
        do{
        Menu();
            cout<<"Which mathematical topic do you want?:";
            cin>>submenu;
            switch (submenu){
                case 1:
                    cout<<"Welcome to Taylor";
                    cin>>submenu;
                    break;
                    case 2:
                        cout<<"Welcome to ewan";
                        cin>>submenu;
                        break;
                        case 3:
                            cout<<"Welcome to ewan\n";
                            cin>>submenu;
                            break;
                            case 4:
                                cout<<"Thank you zzz\n";
                                break;
                                    default:
                                    cout<<"Invalid input, try again:";
                                    cin>>submenu;
            }   
        }
        while (submenu!=4);
        break;
        case 2:
            cout<<"Which mathematical topic do you want?";
            cin>>x;
            break;
                case 3:
                cout<<"thank you zzz";
                cin>>x;
                break;
                    default:
                    cout<<"Invalid input, try again:";
                    cin>>x;
        }
}
while (x!=3);

return 0;
}