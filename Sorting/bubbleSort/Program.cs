// bubble sort
int[] array={3,5,7,1,9,2,6};
int[] sortedArray=array;
int temp=0;
for(int i=0;i<array.Length-1;i++){
    for(int j=i+1;j<array.Length;j++){
        if(array[i]>array[j]){
        temp=array[i];
        sortedArray[i]=array[j];
        sortedArray[j]=temp;
    }
    }
}

for(int i=0;i<array.Length;i++){
    Console.Write(sortedArray[i]);
}