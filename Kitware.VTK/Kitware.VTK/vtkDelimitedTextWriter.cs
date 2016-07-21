using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDelimitedTextWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDelimitedTextWriter";

		public new static readonly string MRClassNameKey;

		static vtkDelimitedTextWriter()
		{
			vtkDelimitedTextWriter.MRClassNameKey = "class vtkDelimitedTextWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDelimitedTextWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDelimitedTextWriter"));
		}

		public vtkDelimitedTextWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelimitedTextWriter New()
		{
			vtkDelimitedTextWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelimitedTextWriter.vtkDelimitedTextWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDelimitedTextWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDelimitedTextWriter.vtkDelimitedTextWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextWriter_GetFieldDelimiter_01(HandleRef pThis);

		public virtual string GetFieldDelimiter()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetFieldDelimiter_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextWriter_GetFileName_02(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetFileName_02(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextWriter_GetStringDelimiter_03(HandleRef pThis);

		public virtual string GetStringDelimiter()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetStringDelimiter_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextWriter_GetUseStringDelimiter_04(HandleRef pThis);

		public virtual bool GetUseStringDelimiter()
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetUseStringDelimiter_04(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkDelimitedTextWriter_GetWriteToOutputString_05(HandleRef pThis);

		public virtual bool GetWriteToOutputString()
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_GetWriteToOutputString_05(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDelimitedTextWriter_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkDelimitedTextWriter_IsTypeOf_07(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDelimitedTextWriter.vtkDelimitedTextWriter_IsTypeOf_07(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDelimitedTextWriter NewInstance()
		{
			vtkDelimitedTextWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelimitedTextWriter.vtkDelimitedTextWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextWriter_RegisterAndGetOutputString_10(HandleRef pThis);

		public string RegisterAndGetOutputString()
		{
			return Marshal.PtrToStringAnsi(vtkDelimitedTextWriter.vtkDelimitedTextWriter_RegisterAndGetOutputString_10(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkDelimitedTextWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDelimitedTextWriter SafeDownCast(vtkObjectBase o)
		{
			vtkDelimitedTextWriter vtkDelimitedTextWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDelimitedTextWriter.vtkDelimitedTextWriter_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDelimitedTextWriter = (vtkDelimitedTextWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDelimitedTextWriter.Register(null);
				}
			}
			return vtkDelimitedTextWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextWriter_SetFieldDelimiter_12(HandleRef pThis, string _arg);

		public virtual void SetFieldDelimiter(string _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetFieldDelimiter_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextWriter_SetFileName_13(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetFileName_13(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextWriter_SetStringDelimiter_14(HandleRef pThis, string _arg);

		public virtual void SetStringDelimiter(string _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetStringDelimiter_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextWriter_SetUseStringDelimiter_15(HandleRef pThis, byte _arg);

		public virtual void SetUseStringDelimiter(bool _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetUseStringDelimiter_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextWriter_SetWriteToOutputString_16(HandleRef pThis, byte _arg);

		public virtual void SetWriteToOutputString(bool _arg)
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_SetWriteToOutputString_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextWriter_WriteToOutputStringOff_17(HandleRef pThis);

		public virtual void WriteToOutputStringOff()
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_WriteToOutputStringOff_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkDelimitedTextWriter_WriteToOutputStringOn_18(HandleRef pThis);

		public virtual void WriteToOutputStringOn()
		{
			vtkDelimitedTextWriter.vtkDelimitedTextWriter_WriteToOutputStringOn_18(base.GetCppThis());
		}
	}
}
