//    Copyright 2006, 2007, 2008 East Tech Incorporated
//
//    This file is part of FIX4NET.
//
//    FIX4NET is free software: you can redistribute it and/or modify
//    it under the terms of the GNU Lesser General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    FIX4NET is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public License
//    along with FIX4NET.  If not, see <http://www.gnu.org/licenses/>.
//
using System;

namespace FIX4NET.MessageCache.FlatFile
{
    /// <summary>
    /// Generates a date trailer string using the standard Date/Time formatter.
    /// </summary>
    public class FileDateFormat : IFileDateFormat
    {
        private string _format = "yyyyMMdd";

        /// <summary>
        /// Format to be used when generating the date trailer at the end of a file.
        /// </summary>
        public string Format
        {
            get { return _format; }
            set { _format = value; }
        }

        /// <summary>
        /// Create the trailer string put at the end of the file name to roll files.
        /// </summary>
        /// <param name="date">The date to be used when generating the file name trailer.</param>
        /// <returns>The value that gets appended to the file name to roll files.</returns>
        public string ToString(DateTime date)
        {
            return date.ToString(_format);
        }
    }
}
