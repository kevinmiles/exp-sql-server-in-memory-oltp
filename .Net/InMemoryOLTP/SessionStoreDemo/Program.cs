﻿/****************************************************************************/
/*                       Expert SQL Server In-Memory OLTP                   */
/*      APress. 1st Edition. ISBN-13:978-1484211373  ISBN-10:1484211375     */
/*                                                                          */
/*           Written by Dmitri V. Korotkevitch & Vladimir Zatuliveter       */
/*                      http://aboutsqlserver.com                           */
/*                        dk@aboutsqlserver.com                             */
/****************************************************************************/
/*                     Chapter 11 - Session Store Demo                      */
/****************************************************************************/

using Actsoft.Com.SessionStoreDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboutSqlServer.Com.SessionStoreDemo
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
            Application.Run(new frmMain());
        }
    }
}