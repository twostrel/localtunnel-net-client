﻿/*
Copyright (C) 2011 by Daniel Ramirez (hello@danielrmz.com)

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tamir.SharpSsh.jsch;

namespace LocalTunnel.Models
{
    /// <summary>
    /// User information class required by SharpSSH so the connection
    /// authentication handles correctly the events.
    /// </summary>
    internal class MyUserInfo : UserInfo
    {
        #region UserInfo Members

        /// <summary>
        /// We are assuming no passphrase in the key files
        /// </summary>
        /// <returns></returns>
        public string getPassphrase()
        {
            return string.Empty;
        }

        /// <summary>
        /// No password since the connection is by publickey
        /// </summary>
        /// <returns></returns>
        public string getPassword()
        {
            return string.Empty;
        }

        /// <summary>
        /// No passphrase required
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool promptPassphrase(string message)
        {
            return false;
        }

        /// <summary>
        /// No password required
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool promptPassword(string message)
        {
            return false;
        }

        /// <summary>
        /// Accept adding the key fingerprints
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public bool promptYesNo(string message)
        {
            return true;
        }

        /// <summary>
        /// Output to console if required
        /// </summary>
        /// <param name="message"></param>
        public void showMessage(string message)
        {
            Console.WriteLine(message);
        }

        #endregion
    }
}
