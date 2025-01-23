using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

public class KycQrCode
{
    byte[] Kyc;


    public KycQrCode(string _Kyc)
    {
       
        Kyc = Encoding.UTF8.GetBytes(_Kyc);
    }
    private byte[] getBytes(int id, byte[] Value)
    {
        List<byte> val = new List<byte>();
        val.Add((byte)id);
        val.AddRange(BitConverter.GetBytes((ushort)Value.Length));
        val.AddRange(Value);
        return val.ToArray();
    }
    public string ToBase64()
    {
        List<byte> bytes = new List<byte>();
        bytes.AddRange(getBytes(1, Kyc));

        return Convert.ToBase64String(bytes.ToArray());
    }

}