using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkOutputStream : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkOutputStream";

		public new static readonly string MRClassNameKey;

		static vtkOutputStream()
		{
			vtkOutputStream.MRClassNameKey = "class vtkOutputStream";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOutputStream.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOutputStream"));
		}

		public vtkOutputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOutputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutputStream New()
		{
			vtkOutputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutputStream.vtkOutputStream_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkOutputStream() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkOutputStream.vtkOutputStream_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOutputStream_EndWriting_01(HandleRef pThis);

		public virtual int EndWriting()
		{
			return vtkOutputStream.vtkOutputStream_EndWriting_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOutputStream_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkOutputStream.vtkOutputStream_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOutputStream_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkOutputStream.vtkOutputStream_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOutputStream_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkOutputStream NewInstance()
		{
			vtkOutputStream result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutputStream.vtkOutputStream_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOutputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkOutputStream_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkOutputStream SafeDownCast(vtkObjectBase o)
		{
			vtkOutputStream vtkOutputStream = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkOutputStream.vtkOutputStream_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOutputStream = (vtkOutputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOutputStream.Register(null);
				}
			}
			return vtkOutputStream;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOutputStream_StartWriting_07(HandleRef pThis);

		public virtual int StartWriting()
		{
			return vtkOutputStream.vtkOutputStream_StartWriting_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOutputStream_Write_08(HandleRef pThis, IntPtr data, uint length);

		public virtual int Write(IntPtr data, uint length)
		{
			return vtkOutputStream.vtkOutputStream_Write_08(base.GetCppThis(), data, length);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkOutputStream_Write_09(HandleRef pThis, string data, uint length);

		public int Write(string data, uint length)
		{
			return vtkOutputStream.vtkOutputStream_Write_09(base.GetCppThis(), data, length);
		}
	}
}
