﻿/*
    Copyright 2015 MCGalaxy
    
    Dual-licensed under the Educational Community License, Version 2.0 and
    the GNU General Public License, Version 3 (the "Licenses"); you may
    not use this file except in compliance with the Licenses. You may
    obtain a copy of the Licenses at
    
    http://www.opensource.org/licenses/ecl2.php
    http://www.gnu.org/licenses/gpl-3.0.html
    
    Unless required by applicable law or agreed to in writing,
    software distributed under the Licenses are distributed on an "AS IS"
    BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
    or implied. See the Licenses for the specific language governing
    permissions and limitations under the Licenses.
 */
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace MCGalaxy.Util {

    public sealed class UndoFileBin : UndoFile {
        
        protected override string Extension { get { return ".unbin"; } }

        protected override void SaveUndoData(Player p, string path) {
            throw new NotImplementedException();
        }
        
        protected override bool UndoEntry(Player p, string[] lines, long seconds) {
            throw new NotImplementedException();
        }
        
        protected override bool HighlightEntry(Player p, string[] lines, long seconds) {
            throw new NotImplementedException();
        }
    }
}
