﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace dnSpy.Contracts.Text.Editor {
	/// <summary>
	/// Word wrap style
	/// </summary>
	[Flags]
	public enum WordWrapStyles {
		/// <summary>
		/// Word wrap is disabled
		/// </summary>
		None = 0,

		/// <summary>
		/// Word wrap is enabled
		/// </summary>
		WordWrap = 1,

		/// <summary>
		/// Word wrap glyphs are shown, only used if <see cref="WordWrap"/> bit is set
		/// </summary>
		VisibleGlyphs = 2,

		/// <summary>
		/// The wrapped line is auto indented, only used if <see cref="WordWrap"/> bit is set
		/// </summary>
		AutoIndent = 4,

		/// <summary>
		/// Word wrap disabled with <see cref="VisibleGlyphs"/> and <see cref="AutoIndent"/> set
		/// </summary>
		DefaultDisabled = None | VisibleGlyphs | AutoIndent,
	}
}