class array
{
    void Learn1DArray()
    {
        int[] ages= new int[10];
        double[] salary = new double[10];

        ages[0]= 10;
        salary[0]= 2000;

        float[] marks = new float[] {27.8f, 33.4f, 55.6f};
        float[] marks2 = {27.8f, 33.4f, 55.6f};
    }

    void LearnMulDArray()
    {
        //2D array
        int[,] agesMatrix= new int[10,15];

        //3D array
        int[,,] arrayMatrix3D = new int[10,15,5]; //it has 10 items with 15 rows and 5 columns.

        string[,] names = new string[,] {{"ram","shrestha"},{"shyam","adhikari"}};


    }

    void LearnJaggedArray()
    {
        byte[][] personAge = new byte[3][];
        personAge[0] = new byte[3] { 22 , 45, 55};
        personAge[1] = new byte[] {32, 33 , 44 ,55 };
        personAge[2] = new byte[] {44,55,66,77};
    }
}