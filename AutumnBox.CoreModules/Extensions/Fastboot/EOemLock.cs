﻿/*************************************************
** auth： zsh2401@163.com
** date:  2018/9/12 16:01:08 (UTC +8:00)
** desc： ...
*************************************************/
using AutumnBox.CoreModules.Aspect;
using AutumnBox.OpenFramework.Extension;

namespace AutumnBox.CoreModules.Extensions.Fastboot
{
    //[ExtName("加上BL锁", "en-us:Lock oem")]
    //[ExtDesc("觉得解BL后不安全?想养老了?", "en-us:Do you wanna relock oem for your device?")]
    //[ExtIcon("Icons.lock.png")]
    //[ExtRequiredDeviceStates(Basic.Device.DeviceState.Fastboot)]
    //[UserAgree("EOemLockWarn")]
    //[UserAgree("EOemLockWarnAgain")]
    //internal class EOemLock : OfficialVisualExtension
    //{
    //    protected override int VisualMain()
    //    {
    //        WriteInitInfo();
    //        var result = CmdStation.GetFastbootCommand(TargetDevice, "oem lock")
    //             .To(OutputPrinter)
    //             .Execute();
    //        WriteExitCode(result.ExitCode);
    //        return result.ExitCode;
    //    }
    //}
}
