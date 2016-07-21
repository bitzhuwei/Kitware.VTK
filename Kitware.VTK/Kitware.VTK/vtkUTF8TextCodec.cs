using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkUTF8TextCodec : vtkTextCodec
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkUTF8TextCodec";

		public new static readonly string MRClassNameKey;

		static vtkUTF8TextCodec()
		{
			vtkUTF8TextCodec.MRClassNameKey = "class vtkUTF8TextCodec";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUTF8TextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUTF8TextCodec"));
		}

		public vtkUTF8TextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF8TextCodec_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUTF8TextCodec New()
		{
			vtkUTF8TextCodec result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUTF8TextCodec.vtkUTF8TextCodec_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF8TextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkUTF8TextCodec() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkUTF8TextCodec.vtkUTF8TextCodec_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkUTF8TextCodec_CanHandle_01(HandleRef pThis, string testStr);

		public override bool CanHandle(string testStr)
		{
			return vtkUTF8TextCodec.vtkUTF8TextCodec_CanHandle_01(base.GetCppThis(), testStr) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUTF8TextCodec_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkUTF8TextCodec.vtkUTF8TextCodec_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkUTF8TextCodec_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkUTF8TextCodec.vtkUTF8TextCodec_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF8TextCodec_Name_04(HandleRef pThis);

		public override string Name()
		{
			return Marshal.PtrToStringAnsi(vtkUTF8TextCodec.vtkUTF8TextCodec_Name_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF8TextCodec_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkUTF8TextCodec NewInstance()
		{
			vtkUTF8TextCodec result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUTF8TextCodec.vtkUTF8TextCodec_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF8TextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkUTF8TextCodec_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkUTF8TextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkUTF8TextCodec vtkUTF8TextCodec = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkUTF8TextCodec.vtkUTF8TextCodec_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUTF8TextCodec = (vtkUTF8TextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUTF8TextCodec.Register(null);
				}
			}
			return vtkUTF8TextCodec;
		}
	}
}
