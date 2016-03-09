#include <stdio.h>
#include <limits.h>
#include <float.h>

int main() {
	/*prints size in bytes*/
	
	printf("Storage size for int : %lu \n", sizeof(int));
	printf("Storage size for float : %lu \n", sizeof(float));
	printf("Minimum float positive value : %E \n", FLT_MIN);
	printf("Maximum float positive value : %E \n", FLT_MAX);
	printf("Precision value: %d \n", FLT_DIG);
	
	
	return 0;
}
