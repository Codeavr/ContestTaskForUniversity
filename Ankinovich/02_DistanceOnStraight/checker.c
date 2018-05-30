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

    double right = answer.readReal();
    double recv = output.readReal();

    if(recv != right)
        quitf(_wa, "wrong answer");

    quitf(_ok, "right answer");
}
