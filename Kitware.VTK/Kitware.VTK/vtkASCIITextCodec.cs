using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkASCIITextCodec : vtkTextCodec
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkASCIITextCodec";

		public new static readonly string MRClassNameKey;

		static vtkASCIITextCodec()
		{
			vtkASCIITextCodec.MRClassNameKey = "class vtkASCIITextCodec";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkASCIITextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkASCIITextCodec"));
		}

		public vtkASCIITextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkASCIITextCodec_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkASCIITextCodec New()
		{
			vtkASCIITextCodec result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkASCIITextCodec.vtkASCIITextCodec_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkASCIITextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkASCIITextCodec() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkASCIITextCodec.vtkASCIITextCodec_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern byte vtkASCIITextCodec_CanHandle_01(HandleRef pThis, string NameString);

		public override bool CanHandle(string NameString)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_CanHandle_01(base.GetCppThis(), NameString) != 0;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkASCIITextCodec_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkASCIITextCodec_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkASCIITextCodec_Name_04(HandleRef pThis);

		public override string Name()
		{
			return Marshal.PtrToStringAnsi(vtkASCIITextCodec.vtkASCIITextCodec_Name_04(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkASCIITextCodec_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkASCIITextCodec NewInstance()
		{
			vtkASCIITextCodec result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkASCIITextCodec.vtkASCIITextCodec_NewInstance_06(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkASCIITextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkASCIITextCodec_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkASCIITextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkASCIITextCodec vtkASCIITextCodec = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkASCIITextCodec.vtkASCIITextCodec_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkASCIITextCodec = (vtkASCIITextCodec)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkASCIITextCodec.Register(null);
				}
			}
			return vtkASCIITextCodec;
		}
	}
}
