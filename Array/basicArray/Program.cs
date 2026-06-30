string[] names = {"Sanika","Vibha","Nikita","Karan"};

for(int i=0;i<names.Length;i++){
    Console.WriteLine(names[i]);
}

int[] marks=new int[5];
marks[0]=90;
marks[1]=30;
marks[2]=70;
marks[3]=36;
marks[4]=74;

for(int i=0;i<5;i++){
    Console.Write(marks[i]+" ");
}

int[,] arr = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
       Console.Write(arr[i,j] + " ");
    }
     Console.Write("\n");
}


int [,] studentsMarks= new int [2,2];

for (int i = 0; i < 2; i++) {

    for (int j = 0; j < 2; j++) {
       studentsMarks[i,j]=34;
    }
    
}

for (int i = 0; i < 2; i++) {
    for (int j = 0; j < 2; j++) {
       Console.Write(studentsMarks[i,j]);
    }
    Console.Write("\n");    
}

Point[] points=new Point[5];
points[0] = new Point(10, 20);
points[1] = new Point(30, 40);
points[2] = new Point(50, 60);
points[3] = new Point(70, 80);
points[4] = new Point(90, 100);

Console.WriteLine("List of Points:");

        foreach (Point p in points)
        {
           Console.WriteLine(p.X+","+p.Y);
        }

//Addition of two arrays - 1d

int[] array1={2,3,4,5};
int[] array2={4,5,6,7};
int[] sum=new int[4];

Console.WriteLine("1D addition");
for(int i=0;i<array1.Length;i++){
    sum[i]=array1[i]+array2[i];
    Console.Write(sum[i]+" ");
}

//Addition of two arrays - 2d
int[,] arr1 = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

int[,] arr2={
    {2,4,5},
    {1,4,2},
    {2,6,5}
};

int[,] resultArr={
    {3,6,8},
    {5,9,8},
    {9,14,14}
};

int[,] result=new int[3,3];

Console.WriteLine("\n2D array addition");
Console.WriteLine(arr1.Length +"=array1 length");

for(int i=0;i<arr1.GetLength(0);i++){
    for(int j=0;j<arr1.GetLength(1);j++){
        result[i,j]=arr1[i,j]+arr2[i,j];
        Console.Write(result[i,j]+" ");
    }
    Console.Write("\n");
}


Console.WriteLine("Given array is : ");

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
       Console.Write(arr2[i,j]);
    }
    Console.Write("\n");    
}

int[,] transposedArr=new int[3,3];

Console.WriteLine("Transpose of matrix is : ");

for(int i=0;i<3;i++){
    for(int j=0;j<3;j++){
        transposedArr[i,j]=arr2[j,i];
    }
}

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
       Console.Write(transposedArr[i,j]+" ");
    }
    Console.Write("\n");    
}

Console.WriteLine("Diagonal matrix is: ");
int[,] diagonal=new int[3,3];

for (int i = 0; i < 3; i++) {
    for (int j = 0; j < 3; j++) {
        if(i==j){
            diagonal[i,j]=arr2[i,j];
        }else{
            diagonal[i,j]=0;
        }
    Console.Write(diagonal[i,j]+" ");
    } 
    Console.Write("\n");
}

Console.WriteLine("Upper triangular matrix is: ");

int[,] upperTriangular = new int[3,3];

for(int i=0;i<arr2.GetLength(0);i++){
    for(int j=0;j<arr2.GetLength(1);j++){
       if(i>j){
        upperTriangular[i,j]=0;
       }else{
        upperTriangular[i,j]=arr2[i,j];
       }
       Console.Write(upperTriangular[i,j]+" ");
    }
      Console.Write("\n");
}

Console.WriteLine("Lower triangular matrix is: ");

int[,] lowerTriangular = new int[3,3];

for(int i=0;i<arr2.GetLength(0);i++){
    for(int j=0;j<arr2.GetLength(1);j++){
       if(i<j){
         lowerTriangular[i,j]=0;
       }else{
        lowerTriangular[i,j]=arr2[i,j];
       }
       Console.Write(lowerTriangular[i,j]+" ");
    }
    Console.Write("\n");
}

Console.WriteLine("Multiplication of matrix is: ");
int[,] multipliedMatrix=new int[3,3];

int number=0;
int[,] mulresult=new int[2,2];

int[,] arrayy1={
            {4,5},
            {2,3}
};

int[,] arrayy2={
            {2,3},
            {1,4}
};

for(int i=0;i<2;i++){
    for(int j=0;j<2;j++){
        mulresult[i,j]=0;
        for(int n=0;n<2;n++){
           mulresult[i,j]+= (arrayy1[i,n]*arrayy2[n,j]);  
        }
        Console.Write(mulresult[i,j]+" ");
    }  
    Console.Write("\n");
}
