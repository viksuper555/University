#include <stdio.h>
#include <stdlib.h>


typedef struct MinMaxStruct {
    int min;
    int max;
};


struct MinMaxStruct minMax() {

	int n;

	do{
		printf("Please enter n.\n");
		scanf("%d", &n);
	}while(n < 1);

	int first;
	scanf("%d", &first);
	int min = first, max = first;

	for(int i = 1; i < n; i++){
		int number;
		scanf("%d", &number);
		if(number > max)
			max = number;
		if(number < min)
			min = number;
	}

	struct MinMaxStruct result = {min=min, max=max};
	return result;
}

int getInput(char *input[])
{
	int n = 25, max_len = 1000, i = 0;
    char temp[1000];

	for(i = 0; i < n; i++) {
		fgets(temp, sizeof(temp), stdin);
		size_t len = strlen(temp);
		if (len > 1 && temp[len-1] == '\n') {
			temp[--len] = '\0';
		}
		if(strcmp(temp, "\n") == 0)
			break;
		input[i] = malloc(sizeof(char) * 1000);
		strcpy(input[i], temp);	
	}

	return i;
}

void swap(char **str1_ptr, char **str2_ptr)
{
  char *temp = *str1_ptr;
  *str1_ptr = *str2_ptr;
  *str2_ptr = temp;
}  
 
void bubbleSort(char* arr[], int n)
{
   int i, j;
   for (i = 0; i < n-1; i++)     
       for (j = 0; j < n-i-1; j++)
	   {
			if (strcmp(arr[j], arr[j+1]) > 0)
			{
				swap(&arr[j], &arr[j+1]);
			}
	   }
}
 
void print(char* input[], int size)
{
	for (int i = 0; i < size; i++)
	{
		if(strcmp(input[i], "\n") == 0)
			break;
		printf("array[%d] = %s\n",i, input[i]);
	}
}

int countWords(char* path)
{
   	int count = 0;
	FILE* file = fopen(path, "r");
 
    if (NULL == file) {
        printf("file can't be opened \n");
    }
	
    char ch;
    do {
        ch = fgetc(file);
        if(ch == ' ')
			count++; 
    } while (ch != EOF);
 
    fclose(file);
    return count;
}
int main() {
	//1
	// struct MinMaxStruct res = minMax();
	// printf("Min = %d, Max = %d", res.min, res.max);

	//2
	// char *input[25];
	// int count = getInput(&input);
	// bubbleSort(&input, count);
	// print(&input, count);

	// //3
	// char* path = "text.txt";
	// int count = countWords(path);
	// printf("Words count = %d", count);
}