﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoicing
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Forms.frmMain());
    }
    public static CUser LoginUser;
    public static CDatabase DB;
    public static int idActiveOrder;
    public static wOrders ActiveOrder;
  }
}
