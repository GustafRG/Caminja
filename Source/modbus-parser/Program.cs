// See https://aka.ms/new-console-template for more information

using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
       byte[] command = { 0x01, 0x04, 0x33, 0x1A, 0x00, 0x01};

        byte[] message = {0x01, 0x04, 0x02, 0X04, 0xCE};

        byte[] crc2 =  CRC16_MODBUS.CalculateCRC16(message);

        foreach (byte b in command)
        {
            Console.Write("{0:x2} ",b);
        }
        byte[] crc =  CRC16_MODBUS.CalculateCRC16(command);

        foreach(byte b in crc)
        {
            Console.Write("{0:x2} ",b);
        }

        Console.Read();
    }
}