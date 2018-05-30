#include <iostream>
#include "../utils/testlib.h"

using namespace std;

#define input inf
#define output ouf
#define answer ans

int main(int argc, char *argv[])
{
    setName("universal checker");
    registerTestlibCmd(argc, argv);

    string right = answer.readLine();
    string recv = output.readLine();

    if(recv != right)
        quitf(_wa, "wrong answer");

    quitf(_ok, "right answer");
}