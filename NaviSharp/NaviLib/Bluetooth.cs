using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsMobile.SharedSource.Bluetooth;

namespace NaviLib
{
    public class Bluetooth
    {
        public Bluetooth()
        {
            BluetoothRadio BTRadio = new BluetoothRadio();
            foreach (BluetoothDevice device in BTRadio.PairedDevices)
            {
               
            }
        }
    }
}
