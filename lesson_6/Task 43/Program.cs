double[] input_line_data(){
    double[] new_line = new double[2];
    Console.Write("Введите значение коэффциента для прямой >> ");
    new_line[0] = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите значение константы для прямой >> ");
    new_line[1] = Convert.ToDouble(Console.ReadLine());
    return new_line;
}

int do_intersect(double[] line1, double[] line2){
    if(line1[0] == line2[0]){
        if(line1[1] == line2[1]){
            return 2;
        } 
        else{
            return 1;
        }
    }
    return 0;
}

void response_output(double[] line1, double[] line2){
    Console.WriteLine($"Данные прямые y = {line1[0]} * x + {line1[1]} и y = {line2[0]} * x + {line2[1]}");
    int response = do_intersect(line1, line2);
    if(response == 2){
        Console.WriteLine("полностью совпадают!");
    }
    if(response == 1){
        Console.WriteLine("параллельны! И не имеют общих точек.");
    } 
    if(response == 0){
        double[] coordinate_point = find_intersect(line1, line2);
        Console.WriteLine($"пересекаются в точке ({coordinate_point[0]}, {coordinate_point[1]})");
    }
}

double[] find_intersect(double[] line1, double[] line2){
    double[] intersection_point = new double[2];
    intersection_point[0] = (line1[1] - line2[1]) / (line2[0] - line1[0]);
    intersection_point[1] = line1[0] * intersection_point[0] + line1[1];
    return intersection_point;
}

double[] line1 = input_line_data();
double[] line2 = input_line_data();
response_output(line1, line2);