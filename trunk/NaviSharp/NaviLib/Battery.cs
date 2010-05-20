using System;

using System.Collections.Generic;
using System.Text;
using Win32;

namespace NaviLib
{
    public enum TYPE
    {
        ALKALINE,
        LION,
        LIPOLY,
        NICD,
        NIMH,
        UNKNOWN,
        ZINCAIR
    }

    public enum STATUS
    {
        CHARGING,
        CRITICAL,
        HIGH,
        LOW,
        NOBATTERY,
        UNKNOWN
    }

    public class Battery
    {
        public bool Exists = true;
        public bool Charging = false;
        public TYPE Type;
        public STATUS Status;
        public byte Percent=0;
        public int Voltage=0;

        private SYSTEM_POWER_STATUS_EX2 _currentStatus = null;        

        public Battery()
        {
            _currentStatus = CoreDLL.GetSystemPowerStatus(); // read the battery status
            // does the battery exists?
            if (_currentStatus.BatteryFlag == BatteryFlag.BATTERY_FLAG_NO_BATTERY)
            {
                this.Exists = false;
                return;
            }
            // does the battery currently chargeing?
            if (_currentStatus.ACLineStatus == ACLineStatus.AC_LINE_ONLINE && _currentStatus.BatteryFlag == BatteryFlag.BATTERY_FLAG_CHARGING) this.Charging = true;

            // check battery status
            switch (_currentStatus.BatteryFlag)
            {
                case BatteryFlag.BATTERY_FLAG_CHARGING:
                    Status = STATUS.CHARGING;
                    break;
                case BatteryFlag.BATTERY_FLAG_CRITICAL:
                    Status = STATUS.CRITICAL;
                    break;
                case BatteryFlag.BATTERY_FLAG_HIGH:
                    Status = STATUS.HIGH;
                    break;
                case BatteryFlag.BATTERY_FLAG_LOW:
                    Status = STATUS.LOW;
                    break;
                case BatteryFlag.BATTERY_FLAG_NO_BATTERY:
                    Status = STATUS.NOBATTERY;
                    break;
                case BatteryFlag.BATTERY_FLAG_UNKNOWN:
                    Status = STATUS.UNKNOWN;
                    break;
                default:
                    break;
            }

            // find battery type
            switch (_currentStatus.BatteryChemistry)
            {
                case BatteryChemistry.BATTERY_CHEMISTRY_ALKALINE:
                    Type = TYPE.ALKALINE;
                    break;
                case BatteryChemistry.BATTERY_CHEMISTRY_LION:
                    Type = TYPE.LION;
                    break;
                case BatteryChemistry.BATTERY_CHEMISTRY_LIPOLY:
                    Type = TYPE.LIPOLY;
                    break;
                case BatteryChemistry.BATTERY_CHEMISTRY_NICD:
                    Type = TYPE.NICD;
                    break;
                case BatteryChemistry.BATTERY_CHEMISTRY_NIMH:
                    Type = TYPE.NIMH;
                    break;
                case BatteryChemistry.BATTERY_CHEMISTRY_UNKNOWN:
                    Type = TYPE.UNKNOWN;
                    break;
                case BatteryChemistry.BATTERY_CHEMISTRY_ZINCAIR:
                    Type = TYPE.ZINCAIR;
                    break;
                default:
                    break;
            }

            // battery percent
            Percent = _currentStatus.BatteryLifePercent;

            // battery voltage
            Voltage = _currentStatus.BatteryVoltage;
        }
    }
}
