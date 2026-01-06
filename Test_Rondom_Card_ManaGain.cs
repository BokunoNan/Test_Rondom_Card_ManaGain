using System;
					
public class Program
{
    
	public static void Main()
	{
        //ประกาศตัวแปร สุ่ม
        Random dice = new Random();
        // bool CardRandom = true;
        //เอาไว้เคลียร์หน้าจอ
        Console.Clear();
        //เขียนกำหนดหัวข้อ
		Console.WriteLine("สุ่ม Card Art/Quick/Buster");
        Console.WriteLine("----> มาสุ่ม Card กันเถอะ! <----");

       
        //เขียน loop for เพื่อสุ่มการ์ด 5 ใบ
        for (int i = 1; i <= 5; i++){
            //สุ่มการ์ด 1-3
             int card = dice.Next(1,4);
              //สุ่มดวงคริติคอล 1-10
             int Critical = dice.Next(1,11);

            string cardType = "";

        if (card == 1 ){
            //เปลี่ยนสีข้อความ เป็นสีน้ำเงิน
            {cardType = "Art"; Console.ForegroundColor = ConsoleColor.Blue; }
            // Console.ResetColor();
        }
        else if (card == 2){
            //เปลี่ยนสีข้อความ เป็นสีเขียว
           {cardType = "Quick"; Console.ForegroundColor = ConsoleColor.Green;}
            // Console.ResetColor();
        }
        else{
            //เปลี่ยนสีข้อความ เป็นสีแดง
            {cardType = "Buster"; Console.ForegroundColor = ConsoleColor.Red; }
            // Console.ResetColor();
        }
        //พิมพ์ผลลัพธ์
        Console.Write($"Card : {cardType,-6}");
        //ล้างสีข้อความ กลับเป็นค่าเริ่มต้น
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        //พิมพ์ผลลัพธ์ ดวงคริติคอล
        Console.Write(" \b Star : ");
        // วนลูปเพื่อพิมพ์ดาวคริติคอล
        for(int s = 0; s < Critical; s++)
            {
              Console.Write(" ★ ");   
            }
        //พิมพ์ค่าเปอร์เซ็นต์คริติคอล
        Console.WriteLine($" \b {Critical * 10}%");
        Console.ResetColor();
    }
     
    
}
    //  static void WaitForKey(ConsoleKey targetKey)
    // {
    //     Console.WriteLine($"[ Aoko: กดปุ่ม {targetKey} เพื่อกด 10 Roll! ]");
    //     while (Console.ReadKey(true).Key != targetKey);
    // }
}