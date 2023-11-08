#include <iostream>
using namespace std;
int main (int argc , char**  argv){
    int a, b, c;
    cout<<"Nhap vao canh a :";
    cin>>a;
    cout<<"Nhap vao canh b :";
    cin>>b;
    cout<<"Nhap vao canh c :";
    cin>>c;
    if(a<b+c && b<a+c && c<a+b){
        if(a*a == b*b +c*c || b*b == a*a +c*c || c*c == a*a +b*b )
            cout<<"Day la tam giac vuong";
        else if(a==b && b==c)
            count<<"Day la tam giac deu";
        else if(a==b || b==c || c==a)
            count<<"Day la tam giac can";
    }
    else
        count<< "Ba canh a,b,c khong phai la ba canh cua mot tam giac";
    return 0;
}