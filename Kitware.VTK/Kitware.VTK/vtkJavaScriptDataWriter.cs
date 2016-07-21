using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkJavaScriptDataWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkJavaScriptDataWriter";

		public new static readonly string MRClassNameKey;

		static vtkJavaScriptDataWriter()
		{
			vtkJavaScriptDataWriter.MRClassNameKey = "class vtkJavaScriptDataWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJavaScriptDataWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJavaScriptDataWriter"));
		}

		public vtkJavaScriptDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJavaScriptDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkJavaScriptDataWriter New()
		{
			vtkJavaScriptDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkJavaScriptDataWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJavaScriptDataWriter_GetFileName_01(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetFileName_01(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkJavaScriptDataWriter_GetIncludeFieldNames_02(HandleRef pThis);

		public virtual bool GetIncludeFieldNames()
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetIncludeFieldNames_02(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJavaScriptDataWriter_GetVariableName_03(HandleRef pThis);

		public virtual string GetVariableName()
		{
			return Marshal.PtrToStringAnsi(vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_GetVariableName_03(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJavaScriptDataWriter_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkJavaScriptDataWriter_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJavaScriptDataWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkJavaScriptDataWriter NewInstance()
		{
			vtkJavaScriptDataWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkJavaScriptDataWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkJavaScriptDataWriter SafeDownCast(vtkObjectBase o)
		{
			vtkJavaScriptDataWriter vtkJavaScriptDataWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJavaScriptDataWriter = (vtkJavaScriptDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJavaScriptDataWriter.Register(null);
				}
			}
			return vtkJavaScriptDataWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJavaScriptDataWriter_SetFileName_09(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SetFileName_09(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJavaScriptDataWriter_SetIncludeFieldNames_10(HandleRef pThis, byte _arg);

		public virtual void SetIncludeFieldNames(bool _arg)
		{
			vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SetIncludeFieldNames_10(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkJavaScriptDataWriter_SetVariableName_11(HandleRef pThis, string _arg);

		public virtual void SetVariableName(string _arg)
		{
			vtkJavaScriptDataWriter.vtkJavaScriptDataWriter_SetVariableName_11(base.GetCppThis(), _arg);
		}
	}
}
