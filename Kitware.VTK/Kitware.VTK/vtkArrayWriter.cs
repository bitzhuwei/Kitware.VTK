using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkArrayWriter : vtkWriter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayWriter";

		public new static readonly string MRClassNameKey;

		static vtkArrayWriter()
		{
			vtkArrayWriter.MRClassNameKey = "class vtkArrayWriter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayWriter"));
		}

		public vtkArrayWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayWriter New()
		{
			vtkArrayWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayWriter.vtkArrayWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkArrayWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkArrayWriter.vtkArrayWriter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkArrayWriter_BinaryOff_01(HandleRef pThis);

		public virtual void BinaryOff()
		{
			vtkArrayWriter.vtkArrayWriter_BinaryOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkArrayWriter_BinaryOn_02(HandleRef pThis);

		public virtual void BinaryOn()
		{
			vtkArrayWriter.vtkArrayWriter_BinaryOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkArrayWriter_GetBinary_03(HandleRef pThis);

		public virtual int GetBinary()
		{
			return vtkArrayWriter.vtkArrayWriter_GetBinary_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayWriter_GetFileName_04(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkArrayWriter.vtkArrayWriter_GetFileName_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkArrayWriter_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrayWriter.vtkArrayWriter_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkArrayWriter_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrayWriter.vtkArrayWriter_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrayWriter NewInstance()
		{
			vtkArrayWriter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayWriter.vtkArrayWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayWriter SafeDownCast(vtkObjectBase o)
		{
			vtkArrayWriter vtkArrayWriter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayWriter.vtkArrayWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayWriter = (vtkArrayWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayWriter.Register(null);
				}
			}
			return vtkArrayWriter;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkArrayWriter_SetBinary_10(HandleRef pThis, int _arg);

		public virtual void SetBinary(int _arg)
		{
			vtkArrayWriter.vtkArrayWriter_SetBinary_10(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkArrayWriter_SetFileName_11(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkArrayWriter.vtkArrayWriter_SetFileName_11(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkArrayWriter_Write_12(HandleRef pThis);

		public override int Write()
		{
			return vtkArrayWriter.vtkArrayWriter_Write_12(base.GetCppThis());
		}
	}
}
