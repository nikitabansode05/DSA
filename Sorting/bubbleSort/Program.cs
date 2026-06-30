// bubble sort
public class Program{

    public static int[] bubbleSort(int[] array){

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
        return sortedArray;
    }

    public static void display(int[] array){
        for(int i=0;i<array.Length;i++){
            Console.Write(array[i]);
        }
    }

    public static void Main(){
        int[] array={1,4,6,2,9,5};
        int[] bsarray=bubbleSort(array);
        display(bsarray);
    }
}
