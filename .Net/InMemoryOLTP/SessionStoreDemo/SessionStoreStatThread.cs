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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutSqlServer.Com.Classes;

namespace Actsoft.Com.SessionStoreDemo
{
    public class SessionStoreStatThread : StatThread
    {
        public SessionStoreStatThread(int sleep, List<BaseThread> threads, frmMain frmMain)
            : base(sleep, threads)
        {
            _frmMain = frmMain;
        }

        protected override void DoIteration()
        {
            if (!_terminated)
            {
                _frmMain.Invoke(_frmMain.UpdateExecStats, new object[] { WorkerThreadsCallsPerSec });
            }
        }

        private frmMain _frmMain;
    }
}
