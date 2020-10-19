﻿using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Windows.Storage;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.System;
using System.IO;

namespace Folder_Prettifier.Tools
{
    enum AutoNameManipulation
    {
        None, Capitalize, AntiCapitalize, AllCapital, AllSmall
    }

    enum AutoCategorizeFiles
    {
        Extensions, Date, None
    }

    class NameAppend
    {
        public string AtStart = "";
        public string AtEnd = "";
    }

    class Manage
    {
        async public static Task Start(bool isNameManipulation,
                          AutoNameManipulation nameManipulation,
                          NameAppend nameAppend,
                          bool isAutoCategorize,
                          AutoCategorizeFiles autoCategorizeFiles)
        {
            // File.WriteAllText(@"A:\hello.txt", "Content is this!");
            //StorageFile file = await StorageFile.GetFileFromPathAsync("file:///A:/hello.txt");
            //await file.MoveAsync(await StorageFolder.GetFolderFromPathAsync("D:"), "hello.txt");
            

            /*
            return;
            Notification.WithIconAndAction("Folder Management Done",
                "Processes successfully ran. Now you can enjoy your well organised folder.",
                "https://unsplash.it/64?image=1005",
                new NotificationAction
                {
                    name = "Open Folder",
                    action = $@"openFolder=C:\",
                    type = ToastActivationType.Background
                });
            */
        }
    }
}
