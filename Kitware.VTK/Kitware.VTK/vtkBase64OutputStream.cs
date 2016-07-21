using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkBase64OutputStream : vtkOutputStream
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkBase64OutputStream";

		public new static readonly string MRClassNameKey;

		static vtkBase64OutputStream()
		{
			vtkBase64OutputStream.MRClassNameKey = "class vtkBase64OutputStream";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBase64OutputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64OutputStream"));
		}

		public vtkBase64OutputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64OutputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBase64OutputStream New()
		{
			vtkBase64OutputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64OutputStream.vtkBase64OutputStream_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64OutputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkBase64OutputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkBase64OutputStream.vtkBase64OutputStream_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64OutputStream_EndWriting_01(HandleRef pThis);

		public override int EndWriting()
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_EndWriting_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64OutputStream_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64OutputStream_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64OutputStream_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkBase64OutputStream NewInstance()
		{
			vtkBase64OutputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64OutputStream.vtkBase64OutputStream_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBase64OutputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkBase64OutputStream_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkBase64OutputStream SafeDownCast(vtkObjectBase o)
		{
			vtkBase64OutputStream vtkBase64OutputStream = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkBase64OutputStream.vtkBase64OutputStream_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBase64OutputStream = (vtkBase64OutputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBase64OutputStream.Register(null);
				}
			}
			return vtkBase64OutputStream;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64OutputStream_StartWriting_07(HandleRef pThis);

		public override int StartWriting()
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_StartWriting_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkBase64OutputStream_Write_08(HandleRef pThis, IntPtr data, uint length);

		public override int Write(IntPtr data, uint length)
		{
			return vtkBase64OutputStream.vtkBase64OutputStream_Write_08(base.GetCppThis(), data, length);
		}
	}
}
