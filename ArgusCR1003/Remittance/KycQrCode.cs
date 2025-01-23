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
        byte[] val = new byte[2 + Value.Length];
        val[0] = (byte)id;
        val[1] = (byte)Value.Length;
        Value.CopyTo(val, 2);
        return val;
    }
    public string ToBase64()
    {
        List<byte> bytes = new List<byte>();
        bytes.AddRange(getBytes(1, Kyc));

        return Convert.ToBase64String(bytes.ToArray());
    }

}