#include <iostream>
#include <fstream>
#include <cmath>

using namespace std;

//страница 245 учебника, там есть пример, как чо делать

int main()
{
    cout << "Enter a name of file.txt: ";
    string nameFile;
    cin >> nameFile;
    nameFile = "golovnev.txt";
    ifstream in(nameFile);
    if (!in.is_open())
        return -1;

    int n = 50;
    float X[n];
    int Yi[n];
    float xMin = 1000, xMax = 0;
    int yMin = 1000, yMax = 0;
    for (int i = 0; i < n; i++){
        in >> X[i] >> Yi[i];

        if (xMin > X[i])
            xMin = X[i];
        if (xMax < X[i])
            xMax = X[i];

        if (yMin > Yi[i])
            yMin = Yi[i];
        if (yMax < Yi[i])
            yMax = Yi[i];
        cout << X[i] << "\t" << Yi[i] << endl;
    }
    cout << "Xmin = " << xMin << "\tXmax = " << xMax << endl;

    int r = 7;
    double Rx = xMax - xMin;
    double Hx = Rx / r;
    cout << "H = " << Hx << endl;
    //функция округления до большего
    int ceilHx = ceil(Hx);
    cout << "Rounded Hx = " << ceilHx << endl;

    //минимальное число Х
    cout << "Xmin = " << xMin << endl;
    int xBorderLeft = floor(xMin);
    cout << "Rouded Xmin = " << xBorderLeft << endl;

    //создание таблицы групированного ряда
    string Header[6] = {"i", "[ a(i - 1) ; a(i) )", "x(i)*", "n(i)", "n(i)/n", "n(i)/nh(x)"};
    int dataBase[7][6];

    //вычисление n(i)
    int data[7] = {0};
    for (int i = 0; i < n; i++){
            if (xBorderLeft <= X[i] && X[i] < xBorderLeft + ceilHx)
                data[0]++;
            else if (xBorderLeft + ceilHx <= X[i] && X[i] < xBorderLeft + ceilHx * 2)
                data[1]++;
            else if (xBorderLeft + ceilHx * 2 <= X[i] && X[i] < xBorderLeft + ceilHx * 3)
                data[2]++;
            else if (xBorderLeft + ceilHx * 3 <= X[i] && X[i] < xBorderLeft + ceilHx * 4)
                data[3]++;
            else if (xBorderLeft + ceilHx * 4 <= X[i] && X[i] < xBorderLeft + ceilHx * 5)
                data[4]++;
            else if (xBorderLeft + ceilHx * 5 <= X[i] && X[i] < xBorderLeft + ceilHx * 6)
                data[5]++;
            else if (xBorderLeft + ceilHx * 6 <= X[i] && X[i] < xBorderLeft + ceilHx * 7)
                data[6]++;
        }

    cout << "N(i):" << endl;
    for (int i = 0; i < r; i++){
        dataBase[i][0] = i + 1;
        dataBase[i][3] = data[i];
        cout << i + 1 << "\t" << dataBase[i][3] << endl;
    }

    //находим X(i)* = (X(i - 1) + X(i)) / 2;
    cout << endl << "X(i)*: " << endl;
    for (int i = 0; i < r; i++){
        int average = int((xBorderLeft + ceilHx * i) / 2 + (xBorderLeft + ceilHx * (i + 1)) / 2);
        dataBase[i][2] = average;
        cout << i + 1 << "\t" << average << endl;
    }

    //находим dataBase[i][4], dataBase[i][5]
    cout << endl << "N(i)/n: " << endl;
    for (int i = 0; i < r; i++){
        double _out = dataBase[i][3] / n;
        //dataBase[i][4] = _out;
        cout << i + 1 << "\t" << _out << endl;
    }

    cout << endl << "N(i) / (n * H(x)): " << endl;
    for (int i = 0; i < r; i++){
        double _out = dataBase[i][3] / (ceilHx * n);
        //dataBase[i][5] = out;
        cout << i + 1 << "\t" << _out << endl;
    }

    //2 часть ---------------------------------------

    int dataBase2Chapter[7][6];

    int

    //3 часть

    return 0;
}

