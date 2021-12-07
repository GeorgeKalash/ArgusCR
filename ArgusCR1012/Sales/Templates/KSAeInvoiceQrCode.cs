using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

public class KSAeInvoiceQrCode
{
    byte[] vendorName;
    byte[] VatNo;
    byte[] invoiceDate;
    byte[] amount;
    byte[] vatAmount;

    public KSAeInvoiceQrCode(string _vendorName, string _vatNo, DateTime _invoiceDate, string _amount, string _vatAmount)
    {
        string dt = _invoiceDate.ToString("yyyy-MM-ddTHH:mm:ss") + "+03";
        vendorName = Encoding.UTF8.GetBytes(_vendorName);
        VatNo = Encoding.UTF8.GetBytes(_vatNo);
        invoiceDate = Encoding.UTF8.GetBytes(dt);
        amount = Encoding.UTF8.GetBytes(_amount);
        vatAmount = Encoding.UTF8.GetBytes(_vatAmount);
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
        bytes.AddRange(getBytes(1, vendorName));
        bytes.AddRange(getBytes(2, VatNo));
        bytes.AddRange(getBytes(3, invoiceDate));
        bytes.AddRange(getBytes(4, amount));
        bytes.AddRange(getBytes(5, vatAmount));
        return Convert.ToBase64String(bytes.ToArray());
    }

}