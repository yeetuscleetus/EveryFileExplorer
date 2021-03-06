﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibEveryFileExplorer.IO.Serialization
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
	public sealed class BinaryStringSignatureAttribute : BinaryAttribute
	{
		readonly String Signature;

		public BinaryStringSignatureAttribute(String Signature)
		{
			this.Signature = Signature;
		}

		public override object Value
		{
			get { return Signature; }
		}
	}
}
